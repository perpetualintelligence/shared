/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using PerpetualIntelligence.Shared.Attributes;
using System.Security.Cryptography.X509Certificates;

namespace PerpetualIntelligence.Protocols.Security.Certificates.X509
{
    /// <summary>
    /// Manages the <see cref="X509Certificate"/> stores and provides the commonly used
    /// <see cref="System.Security.Cryptography.X509Certificates.X509FindType"/> for OpenID Connect authentication protocol.
    /// </summary>
    /// <seealso cref="X509Certificate"/>
    /// <seealso cref="StoreLocation"/>
    /// <seealso cref="StoreName"/>
    /// <seealso cref="X509StoreLocation"/>
    /// <seealso cref="X509FindType"/>
    [Todo("Add X509FindType for all the StoreName")]
    public class X509StoreName
    {
        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        /// <param name="location">The X.509 <see cref="StoreLocation"/>.</param>
        /// <param name="name">The X.509 <see cref="StoreName"/>.</param>
        public X509StoreName(StoreLocation location, StoreName name)
        {
            Location = location;
            Name = name;
        }

        /// <summary>
        /// The X.509 <see cref="System.Security.Cryptography.X509Certificates.X509FindType.FindByIssuerName"/> find by type.
        /// </summary>
        public X509FindType IssuerName => new(Location, Name, System.Security.Cryptography.X509Certificates.X509FindType.FindByIssuerName);

        /// <summary>
        /// The X.509 <see cref="StoreLocation"/>.
        /// </summary>
        public StoreLocation Location { get; }

        /// <summary>
        /// The X.509 <see cref="StoreName"/>.
        /// </summary>
        public StoreName Name { get; }

        /// <summary>
        /// The X.509 <see cref="System.Security.Cryptography.X509Certificates.X509FindType.FindBySerialNumber"/> find
        /// by type.
        /// </summary>
        public X509FindType SerialNumber => new(Location, Name, System.Security.Cryptography.X509Certificates.X509FindType.FindBySerialNumber);

        /// <summary>
        /// The X.509
        /// <see cref="System.Security.Cryptography.X509Certificates.X509FindType.FindBySubjectDistinguishedName"/> find
        /// by type.
        /// </summary>
        public X509FindType SubjectDistinguishedName => new(Location, Name, System.Security.Cryptography.X509Certificates.X509FindType.FindBySubjectDistinguishedName);

        /// <summary>
        /// The X.509 <see cref="System.Security.Cryptography.X509Certificates.X509FindType.FindByThumbprint"/> find by type.
        /// </summary>
        public X509FindType Thumbprint => new(Location, Name, System.Security.Cryptography.X509Certificates.X509FindType.FindByThumbprint);
    }
}
