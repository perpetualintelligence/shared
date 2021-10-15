/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using PerpetualIntelligence.Shared.Attributes;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;

namespace PerpetualIntelligence.Protocols.Oidc
{
    /// <summary>
    /// Creates <see cref="ClaimsPrincipal"/> for OpenID Connect authentication.
    /// </summary>
    [ToDocumentation("Claims from certificate.")]
    public static class ClaimsPrincipalFactory
    {
        /// <summary>
        /// Creates a <see cref="ClaimsIdentity"/> based on information found in an <see cref="X509Certificate2"/>.
        /// </summary>
        /// <param name="certificate">The certificate.</param>
        /// <param name="authenticationType">The authentication type.</param>
        /// <param name="allClaims">
        /// If <c>true</c> this method will add all the relevant <see cref="X509Certificate2"/> claims to the <see cref="ClaimsIdentity"/>.
        /// </param>
        /// <returns>The <see cref="ClaimsIdentity"/> with authentication type and claims.</returns>
        /// <remarks>
        /// If all the claims are not requested, this method will only add <see cref="X509Certificate2.Thumbprint"/> and
        /// <see cref="X509Certificate2.SubjectName"/> claims to the <see cref="ClaimsIdentity"/>.
        /// </remarks>
        public static ClaimsPrincipal FromCertificate(X509Certificate2 certificate, string authenticationType = "X.509", bool? allClaims = false)
        {
            return new ClaimsPrincipal(ClaimsIdentityFactory.FromCertificate(certificate, authenticationType, allClaims));
        }

        /// <summary>
        /// Creates an anonymous <see cref="ClaimsPrincipal"/>. An anonymous claims principal contains an empty
        /// <see cref="ClaimTypes.Name"/> claim.
        /// </summary>
        /// <returns>The anonymous <see cref="ClaimsIdentity"/>.</returns>
        public static ClaimsPrincipal FromAnonymity()
        {
            return new ClaimsPrincipal(ClaimsIdentityFactory.FromAnonymity());
        }

        /// <summary>
        /// Creates a <see cref="ClaimsPrincipal"/> using the specified authentication type and claims.
        /// </summary>
        /// <param name="authenticationType">Type of the authentication.</param>
        /// <param name="claims">The claims.</param>
        /// <returns>The <see cref="ClaimsPrincipal"/> with authentication type and claims.</returns>
        public static ClaimsPrincipal FromClaims(string authenticationType, params Claim[] claims)
        {
            return new ClaimsPrincipal(ClaimsIdentityFactory.FromClaims(authenticationType, claims));
        }
    }
}
