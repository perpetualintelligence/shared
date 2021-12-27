/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
*/

using System.Security.Cryptography.X509Certificates;

namespace PerpetualIntelligence.Protocols.Security.Certificates.X509
{
    /// <summary>
    /// Finds the <see cref="X509Certificate"/> by commonly used <see cref="System.Security.Cryptography.X509Certificates.X509FindType"/>.
    /// </summary>
    /// <seealso cref="X509Certificate"/>
    /// <seealso cref="StoreLocation"/>
    /// <seealso cref="StoreName"/>
    /// <seealso cref="FindByStore"/>
    /// <seealso cref="FindMetadata"/>
    public class FindByType
    {
        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        /// <param name="location">The X.509 <see cref="StoreLocation"/>.</param>
        /// <param name="name">The X.509 <see cref="StoreName"/>.</param>
        public FindByType(StoreLocation location, StoreName name)
        {
            Location = location;
            Name = name;
        }

        /// <summary>
        /// The X.509 <see cref="System.Security.Cryptography.X509Certificates.X509FindType.FindByIssuerName"/> find by type.
        /// </summary>
        public FindMetadata IssuerName => new(Location, Name, System.Security.Cryptography.X509Certificates.X509FindType.FindByIssuerName);

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
        public FindMetadata SerialNumber => new(Location, Name, System.Security.Cryptography.X509Certificates.X509FindType.FindBySerialNumber);

        /// <summary>
        /// The X.509
        /// <see cref="System.Security.Cryptography.X509Certificates.X509FindType.FindBySubjectDistinguishedName"/> find
        /// by type.
        /// </summary>
        public FindMetadata SubjectDistinguishedName => new(Location, Name, System.Security.Cryptography.X509Certificates.X509FindType.FindBySubjectDistinguishedName);

        /// <summary>
        /// The X.509 <see cref="System.Security.Cryptography.X509Certificates.X509FindType.FindByThumbprint"/> find by type.
        /// </summary>
        public FindMetadata Thumbprint => new(Location, Name, System.Security.Cryptography.X509Certificates.X509FindType.FindByThumbprint);
    }
}
