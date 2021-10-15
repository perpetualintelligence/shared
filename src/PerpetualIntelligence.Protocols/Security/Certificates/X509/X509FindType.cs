/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using PerpetualIntelligence.Shared.Attributes;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace PerpetualIntelligence.Protocols.Security.Certificates.X509
{
    /// <summary>
    /// Manages the <see cref="System.Security.Cryptography.X509Certificates.X509FindType"/> for OpenID Connect authentication protocol.
    /// </summary>
    /// <seealso cref="X509Certificate"/>
    /// <seealso cref="StoreLocation"/>
    /// <seealso cref="StoreName"/>
    /// <seealso cref="X509StoreLocation"/>
    /// <seealso cref="X509FindType"/>
    public class X509FindType
    {
        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="location">The X.509 <see cref="StoreLocation"/>.</param>
        /// <param name="name">The X.509 <see cref="StoreName"/>.</param>
        /// <param name="findType">The X.509 <see cref="X509FindType"/>.</param>
        public X509FindType(StoreLocation location, StoreName name, System.Security.Cryptography.X509Certificates.X509FindType findType)
        {
            Location = location;
            Name = name;
            FindType = findType;
        }

        /// <summary>
        /// The X.509 <see cref="System.Security.Cryptography.X509Certificates.X509FindType"/>.
        /// </summary>
        public System.Security.Cryptography.X509Certificates.X509FindType FindType { get; }

        /// <summary>
        /// The X.509 <see cref="StoreLocation"/>.
        /// </summary>
        public StoreLocation Location { get; }

        /// <summary>
        /// The X.509 <see cref="StoreName"/>.
        /// </summary>
        public StoreName Name { get; }

        /// <summary>
        /// Finds the <see cref="X509Certificate2"/>.
        /// </summary>
        /// <param name="findValue"></param>
        /// <param name="validOnly"></param>
        /// <returns></returns>
        [ToUnitTest]
        public IEnumerable<X509Certificate2> Find(object findValue, bool validOnly = true)
        {
            using (X509Store? store = new(Name, Location))
            {
                store.Open(OpenFlags.ReadOnly);

                X509Certificate2Collection? certColl = store.Certificates.Find(FindType, findValue, validOnly);
                return certColl.Cast<X509Certificate2>();
            }
        }
    }
}
