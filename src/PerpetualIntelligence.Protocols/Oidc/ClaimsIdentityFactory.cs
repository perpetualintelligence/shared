/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using PerpetualIntelligence.Shared.Attributes;
using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;

namespace PerpetualIntelligence.Protocols.Oidc
{
    /// <summary>
    /// Creates <see cref="ClaimsIdentity"/> for OpenID Connect authentication.
    /// </summary>
    [WriteDocumentation("Claims from certificate.")]
    public static class ClaimsIdentityFactory
    {
        /// <summary>
        /// Creates an anonymous <see cref="ClaimsIdentity"/>. An anonymous claims identity contains an empty
        /// <see cref="ClaimTypes.Name"/> claim.
        /// </summary>
        /// <returns>The anonymous <see cref="ClaimsIdentity"/>.</returns>
        public static ClaimsIdentity FromAnonymity()
        {
            List<Claim>? claims = new()
            {
                new Claim(ClaimTypes.Name, "")
            };

            return new ClaimsIdentity(claims);
        }

        /// <summary>
        /// Creates a <see cref="ClaimsIdentity"/> based on information found in an <see cref="X509Certificate2"/>.
        /// </summary>
        /// <param name="certificate">The certificate.</param>
        /// <param name="authenticationType">The authentication type.</param>
        /// <param name="allClaims">
        /// If <c>true</c> this method will add all the relevant <see cref="X509Certificate2"/> claims to the <see cref="ClaimsIdentity"/>.
        /// </param>
        /// <returns>The <see cref="ClaimsIdentity"/> with authentication type and cliams.</returns>
        /// <remarks>
        /// If all the claims are not requested, this method will only add <see cref="X509Certificate2.Thumbprint"/> and
        /// <see cref="X509Certificate2.SubjectName"/> claims to the <see cref="ClaimsIdentity"/>.
        /// </remarks>
        public static ClaimsIdentity FromCertificate(X509Certificate2 certificate, string authenticationType = "X.509", bool? allClaims = false)
        {
            var claims = new List<Claim>();
            var issuer = certificate.Issuer;

            claims.Add(new Claim("issuer", issuer));

            var thumbprint = certificate.Thumbprint;
            claims.Add(new Claim(ClaimTypes.Thumbprint, thumbprint, System.Security.Claims.ClaimValueTypes.Base64Binary, issuer));

            var name = certificate.SubjectName.Name;
            if (string.IsNullOrWhiteSpace(name))
            {
                claims.Add(new Claim(ClaimTypes.X500DistinguishedName, name, System.Security.Claims.ClaimValueTypes.String, issuer));
            }

            if (allClaims.GetValueOrDefault())
            {
                name = certificate.SerialNumber;
                if (string.IsNullOrWhiteSpace(name))
                {
                    claims.Add(new Claim(ClaimTypes.SerialNumber, name, System.Security.Claims.ClaimValueTypes.String, issuer));
                }

                name = certificate.GetNameInfo(X509NameType.DnsName, false);
                if (string.IsNullOrWhiteSpace(name))
                {
                    claims.Add(new Claim(ClaimTypes.Dns, name, System.Security.Claims.ClaimValueTypes.String, issuer));
                }

                name = certificate.GetNameInfo(X509NameType.SimpleName, false);
                if (string.IsNullOrWhiteSpace(name))
                {
                    claims.Add(new Claim(ClaimTypes.Name, name, System.Security.Claims.ClaimValueTypes.String, issuer));
                }

                name = certificate.GetNameInfo(X509NameType.EmailName, false);
                if (string.IsNullOrWhiteSpace(name))
                {
                    claims.Add(new Claim(ClaimTypes.Email, name, System.Security.Claims.ClaimValueTypes.String, issuer));
                }

                name = certificate.GetNameInfo(X509NameType.UpnName, false);
                if (string.IsNullOrWhiteSpace(name))
                {
                    claims.Add(new Claim(ClaimTypes.Upn, name, System.Security.Claims.ClaimValueTypes.String, issuer));
                }

                name = certificate.GetNameInfo(X509NameType.UrlName, false);
                if (string.IsNullOrWhiteSpace(name))
                {
                    claims.Add(new Claim(ClaimTypes.Uri, name, System.Security.Claims.ClaimValueTypes.String, issuer));
                }
            }

            return new ClaimsIdentity(claims, authenticationType);
        }

        /// <summary>
        /// Creates a <see cref="ClaimsIdentity"/> using the specified authentication type and claims.
        /// </summary>
        /// <param name="authenticationType">The authentication type.</param>
        /// <param name="claims">The claims to add.</param>
        /// <returns>The <see cref="ClaimsIdentity"/> with authentication type and cliams.</returns>
        public static ClaimsIdentity FromClaims(string authenticationType, params Claim[] claims)
        {
            return new ClaimsIdentity(claims, authenticationType, JwtClaims.Name, JwtClaims.Role);
        }
    }
}
