/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
*/

using PerpetualIntelligence.Shared.Attributes;
using System.Security.Cryptography.X509Certificates;

namespace PerpetualIntelligence.Protocols.Security.Certificates.X509
{
    /// <summary>
    /// Finds the <see cref="X509Certificate"/> by commonly used
    /// <see cref="System.Security.Cryptography.X509Certificates.StoreLocation"/> and <see cref="System.Security.Cryptography.X509Certificates.StoreName"/>.
    /// </summary>
    /// <seealso cref="X509Certificate"/>
    /// <seealso cref="StoreLocation"/>
    /// <seealso cref="StoreName"/>
    /// <seealso cref="FindByType"/>
    /// <seealso cref="FindMetadata"/>
    public class FindByStore
    {
        /// <summary>
        /// Initializes a new instance with the specified <see cref="StoreLocation"/>.
        /// </summary>
        /// <param name="location">The X.509 <see cref="StoreLocation"/>.</param>
        public FindByStore(StoreLocation location)
        {
            Location = location;
        }

        /// <summary>
        /// The X.509 certificate store used by <see cref="StoreLocation.CurrentUser"/>.
        /// </summary>
        public static FindByStore CurrentUser => new(StoreLocation.CurrentUser);

        /// <summary>
        /// The X.509 certificate store assigned to <see cref="StoreLocation.LocalMachine"/>.
        /// </summary>
        public static FindByStore LocalMachine => new(StoreLocation.LocalMachine);

        /// <summary>
        /// The X.509 <see cref="StoreName.AddressBook"/> certificate store.
        /// </summary>
        public FindByType AddressBook => new(Location, StoreName.AddressBook);

        /// <summary>
        /// The X.509 <see cref="StoreName.CertificateAuthority"/> certificate store.
        /// </summary>
        public FindByType CertificateAuthority => new(Location, StoreName.CertificateAuthority);

        /// <summary>
        /// The X509 <see cref="StoreLocation"/>.
        /// </summary>
        public StoreLocation Location { get; }

        /// <summary>
        /// The X.509 <see cref="StoreName.My"/> certificate store.
        /// </summary>
        public FindByType My => new FindByType(Location, StoreName.My);

        /// <summary>
        /// The X.509 <see cref="StoreName.TrustedPeople"/> certificate store.
        /// </summary>
        public FindByType TrustedPeople => new(Location, StoreName.TrustedPeople);

        /// <summary>
        /// The X.509 <see cref="StoreName.TrustedPublisher"/> certificate store.
        /// </summary>
        public FindByType TrustedPublisher => new(Location, StoreName.TrustedPublisher);
    }
}
