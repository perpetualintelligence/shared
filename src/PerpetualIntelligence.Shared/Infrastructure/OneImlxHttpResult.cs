/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
    https://oneimlx.com
*/

using PerpetualIntelligence.Shared.Attributes;
using PerpetualIntelligence.Shared.Extensions;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace PerpetualIntelligence.Shared.Infrastructure
{
    /// <summary>
    /// The generic <c>oneimlx</c> HTTP result.
    /// </summary>
    public class OneImlxHttpResult : OneImlxResult, IDisposable
    {
        /// <summary>
        /// The exception instance if <see cref="ResultType"/> is <see cref="OneImlxHttpResultType.Exception"/>.
        /// </summary>
        public Exception? Exception { get; protected set; }

        /// <summary>
        /// The HTTP response instance if <see cref="ResultType"/> is <see cref="OneImlxHttpResultType.HttpResponse"/>..
        /// </summary>
        public HttpResponseMessage? HttpResponse { get; protected set; }

        /// <summary>
        /// The JSON response.
        /// </summary>
        public JsonElement Json { get; protected set; }

        /// <summary>
        /// The raw response.
        /// </summary>
        public string? Raw { get; protected set; }

        /// <summary>
        /// The result type.
        /// </summary>
        public OneImlxHttpResultType ResultType { get; protected set; }

        /// <summary>
        /// Initializes a new <see cref="OneImlxHttpResult"/> from an exception.
        /// </summary>
        /// <typeparam name="T">The result type.</typeparam>
        /// <param name="ex">The exception.</param>
        /// <param name="additionalInfo">The additional information.</param>
        /// <returns></returns>
        public static T FromException<T>(Exception ex, string? additionalInfo = null) where T : OneImlxHttpResult, new()
        {
            // Set the exception
            T response = new()
            {
                Exception = ex,
                ResultType = OneImlxHttpResultType.Exception,
            };

            // Set the onetime error info
            response.SetErrorWithAdditionalInfo("server_error", ex.Message, additionalInfo);
            return response;
        }

        /// <summary>
        /// Initializes a new <see cref="OneImlxHttpResult"/> from the HTTP response.
        /// </summary>
        /// <typeparam name="T">The result type</typeparam>
        /// <param name="httpResponse">The HTTP response.</param>
        /// <param name="addtionalInfo">The additional information.</param>
        /// <param name="additionalData">The additional data.</param>
        public static async Task<T> FromHttpResponseAsync<T>(HttpResponseMessage httpResponse, string? addtionalInfo = null, [Refactor("Remove this and find a better way to do this ?")] object? additionalData = null) where T : OneImlxHttpResult, new()
        {
            T response = new()
            {
                HttpResponse = httpResponse,
                ResultType = OneImlxHttpResultType.HttpResponse
            };

            // Read the raw response content.
            string? content = null;
            try
            {
                if (httpResponse.Content.Headers.ContentLength > 0)
                {
                    content = await httpResponse.Content.ReadAsStringAsync();
                    response.Raw = content;
                }
            }
            catch
            {
                response.SetErrorWithAdditionalInfo("server_error", $"The HTTP raw response content is not valid. http_status_code={httpResponse.StatusCode}", addtionalInfo);
                return response;
            }

            // Read the Json from raw response.
            if (content != null)
            {
                try
                {
                    response.Json = JsonDocument.Parse(content).RootElement;
                }
                catch
                {
                    response.SetErrorWithAdditionalInfo("server_error", $"The HTTP raw response content is not a valid JSON. raw={content}", addtionalInfo);
                    return response;
                }
            }

            // Something went wrong
            if (!httpResponse.IsSuccessStatusCode)
            {
                // If the HTTP response gave us error details then honor that otherwise formulate std errors
                string? error = response.TryGetFromJson("error");
                if (error != null)
                {
                    response.SetErrorWithAdditionalInfo(error, $"{response.TryGetFromJson("error_description")}", addtionalInfo);
                    return response;
                }
                else
                {
                    // Tailor OneImlx error based on status code
                    if (httpResponse.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        response.SetErrorWithAdditionalInfo("invalid_endpoint", $"The endpoint is not valid or not found. raw={content}", addtionalInfo);
                        return response;
                    }
                    else if (httpResponse.StatusCode == System.Net.HttpStatusCode.Forbidden)
                    {
                        response.SetErrorWithAdditionalInfo("unauthorized_subject", $"The endpoint is not authorized. raw={content}", addtionalInfo);
                        return response;
                    }
                    else
                    {
                        response.SetErrorWithAdditionalInfo("server_error", $"The endpoint is not valid. raw={content}", addtionalInfo);
                        return response;
                    }
                }
            }

            // NO Error Custom Initialize and return
            await response.InitializeAsync(additionalData);
            return response;
        }

        /// <inheritdocs/>
        public void Dispose()
        {
            if (HttpResponse != null)
            {
                HttpResponse.Dispose();
            }
        }

        /// <summary>
        /// Tries to get a specific value from the <see cref="Json"/>.
        /// </summary>
        /// <param name="name">The name.</param>
        public string? TryGetFromJson(string name) => Json.TryGetString(name);

        /// <summary>
        /// Custom initialization for derived classes.
        /// </summary>
        /// <returns></returns>
        protected virtual Task InitializeAsync(object? additionalData)
        {
            return Task.CompletedTask;
        }

        private void SetErrorWithAdditionalInfo(string error, string? errorDescription = null, string? additionalInfo = null)
        {
            string? localEd = errorDescription;
            if (additionalInfo != null)
            {
                localEd = $"{errorDescription} additional_info={additionalInfo}";
            }

            SetError(error, localEd);
        }
    }
}
