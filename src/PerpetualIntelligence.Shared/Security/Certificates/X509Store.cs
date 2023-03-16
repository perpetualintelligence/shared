/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using PerpetualIntelligence.Shared.Attributes;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace PerpetualIntelligence.Shared.Security.Certificates
{
    /// <summary>
    /// The <see cref="X509Certificate2"/> store for OAuth and OpenID Connect protocols.
    /// </summary>
    /// <seealso cref="X509Certificate2"/>
    /// <seealso cref="StoreLocation"/>
    /// <seealso cref="StoreName"/>
    [WriteUnitTest]
    public class X509Store
    {
        /// <summary>
        /// The X.509 certificate store used by <see cref="StoreLocation.CurrentUser"/>.
        /// </summary>
        public static X509Store CurrentUser => new(StoreLocation.CurrentUser);

        /// <summary>
        /// The X.509 certificate store assigned to <see cref="StoreLocation.LocalMachine"/>.
        /// </summary>
        public static X509Store LocalMachine => new(StoreLocation.LocalMachine);

        /// <summary>
        /// Finds the <see cref="X509Certificate2"/> based in the specified <see cref="X509FindType"/>.
        /// </summary>
        /// <param name="storeName">The <see cref="StoreName"/>.</param>
        /// <param name="findType">The <see cref="X509FindType"/>.</param>
        /// <param name="findValue">The find value.</param>
        /// <param name="validOnly">The find value validity.</param>
        /// <returns></returns>
        public IEnumerable<X509Certificate2> Find(StoreName storeName, X509FindType findType, object findValue, bool validOnly = true)
        {
            using (System.Security.Cryptography.X509Certificates.X509Store store = new(storeName, Location))
            {
                store.Open(OpenFlags.ReadOnly);

                X509Certificate2Collection certColl = store.Certificates.Find(findType, findValue, validOnly);
                return certColl.Cast<X509Certificate2>();
            }
        }

        /// <summary>
        /// Initializes a new instance with the specified <see cref="StoreLocation"/>.
        /// </summary>
        /// <param name="location">The X.509 <see cref="StoreLocation"/>.</param>
        private X509Store(StoreLocation location)
        {
            Location = location;
        }

        private StoreLocation Location { get; }
    }
}
