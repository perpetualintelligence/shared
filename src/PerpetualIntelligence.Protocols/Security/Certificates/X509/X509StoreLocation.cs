/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using PerpetualIntelligence.Shared.Attributes;
using System.Security.Cryptography.X509Certificates;

namespace PerpetualIntelligence.Protocols.Security.Certificates.X509
{
    /// <summary>
    /// Manages the <see cref="X509Certificate"/> stores and provides the commonly used <see cref="StoreName"/> for
    /// OpenID Connect authentication protocol.
    /// </summary>
    /// <seealso cref="X509Certificate"/>
    /// <seealso cref="StoreLocation"/>
    /// <seealso cref="StoreName"/>
    /// <seealso cref="X509StoreName"/>
    /// <seealso cref="X509FindType"/>
    [Todo("Add X509StoreName for all the StoreName")]
    public class X509StoreLocation
    {
        /// <summary>
        /// Initializes a new instance with the specified <see cref="StoreLocation"/>.
        /// </summary>
        /// <param name="location">The X.509 <see cref="StoreLocation"/>.</param>
        public X509StoreLocation(StoreLocation location)
        {
            Location = location;
        }

        /// <summary>
        /// The X.509 certificate store used by <see cref="StoreLocation.CurrentUser"/>.
        /// </summary>
        public static X509StoreLocation CurrentUser => new X509StoreLocation(StoreLocation.CurrentUser);

        /// <summary>
        /// The X.509 certificate store assigned to <see cref="StoreLocation.LocalMachine"/>.
        /// </summary>
        public static X509StoreLocation LocalMachine => new X509StoreLocation(StoreLocation.LocalMachine);

        /// <summary>
        /// The X.509 <see cref="StoreName.AddressBook"/> certificate store.
        /// </summary>
        public X509StoreName AddressBook => new X509StoreName(Location, StoreName.AddressBook);

        /// <summary>
        /// The X.509 <see cref="StoreName.CertificateAuthority"/> certificate store.
        /// </summary>
        public X509StoreName CertificateAuthority => new X509StoreName(Location, StoreName.CertificateAuthority);

        /// <summary>
        /// The X.509 store location.
        /// </summary>
        public StoreLocation Location { get; }

        /// <summary>
        /// The X.509 <see cref="StoreName.My"/> certificate store.
        /// </summary>
        public X509StoreName My => new X509StoreName(Location, StoreName.My);

        /// <summary>
        /// The X.509 <see cref="StoreName.TrustedPeople"/> certificate store.
        /// </summary>
        public X509StoreName TrustedPeople => new X509StoreName(Location, StoreName.TrustedPeople);

        /// <summary>
        /// The X.509 <see cref="StoreName.TrustedPublisher"/> certificate store.
        /// </summary>
        public X509StoreName TrustedPublisher => new X509StoreName(Location, StoreName.TrustedPublisher);
    }
}
