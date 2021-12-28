/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
*/

using System.Security.Cryptography.X509Certificates;

namespace PerpetualIntelligence.Protocols.Security.Certificates.X509
{
    /// <summary>
    /// Provides the <see cref="FindMetadata"/> by commonly used
    /// <see cref="System.Security.Cryptography.X509Certificates.StoreLocation"/> and <see cref="System.Security.Cryptography.X509Certificates.StoreName"/>.
    /// </summary>
    /// <seealso cref="X509Certificate"/>
    /// <seealso cref="StoreLocation"/>
    /// <seealso cref="StoreName"/>
    /// <seealso cref="FindMetadataByType"/>
    /// <seealso cref="FindMetadata"/>
    public class FindMetadataByStore
    {
        /// <summary>
        /// Initializes a new instance with the specified <see cref="StoreLocation"/>.
        /// </summary>
        /// <param name="location">The X.509 <see cref="StoreLocation"/>.</param>
        public FindMetadataByStore(StoreLocation location)
        {
            Location = location;
        }

        /// <summary>
        /// The X.509 certificate store used by <see cref="StoreLocation.CurrentUser"/>.
        /// </summary>
        public static FindMetadataByStore CurrentUser => new(StoreLocation.CurrentUser);

        /// <summary>
        /// The X.509 certificate store assigned to <see cref="StoreLocation.LocalMachine"/>.
        /// </summary>
        public static FindMetadataByStore LocalMachine => new(StoreLocation.LocalMachine);

        /// <summary>
        /// The X.509 <see cref="StoreName.AddressBook"/> certificate store.
        /// </summary>
        public FindMetadataByType AddressBook => new(Location, StoreName.AddressBook);

        /// <summary>
        /// The X.509 <see cref="StoreName.CertificateAuthority"/> certificate store.
        /// </summary>
        public FindMetadataByType CertificateAuthority => new(Location, StoreName.CertificateAuthority);

        /// <summary>
        /// The X509 <see cref="StoreLocation"/>.
        /// </summary>
        public StoreLocation Location { get; }

        /// <summary>
        /// The X.509 <see cref="StoreName.My"/> certificate store.
        /// </summary>
        public FindMetadataByType My => new FindMetadataByType(Location, StoreName.My);

        /// <summary>
        /// The X.509 <see cref="StoreName.TrustedPeople"/> certificate store.
        /// </summary>
        public FindMetadataByType TrustedPeople => new(Location, StoreName.TrustedPeople);

        /// <summary>
        /// The X.509 <see cref="StoreName.TrustedPublisher"/> certificate store.
        /// </summary>
        public FindMetadataByType TrustedPublisher => new(Location, StoreName.TrustedPublisher);
    }
}
