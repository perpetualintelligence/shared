/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using PerpetualIntelligence.Shared.Attributes;
using System.Runtime.CompilerServices;

namespace PerpetualIntelligence.Protocols.Security.Secrets
{
    /// <summary>
    /// Compares two string in length-constant time. This comparison method is used so that password hashes and secrets cannot be extracted from on-line systems using a timing attack and then attacked off-line.
    /// </summary>
    public static class SecretComparer
    {
        /// <summary>
        /// Checks two strings in length-constant time.
        /// </summary>
        /// <param name="s1">string 1.</param>
        /// <param name="s2">string 2.</param>
        /// <returns><c>true</c> if the specified strings are equal; otherwise, <c>false</c>.</returns>
        [MethodImpl(MethodImplOptions.NoOptimization)]
        [WriteUnitTest]
        public static bool IsEqual(string? s1, string? s2)
        {
            // FOMAC: change implementation or add cc right
            // add comments explaining
            if (s1 == null && s2 == null)
            {
                return true;
            }

            if (s1 == null || s2 == null)
            {
                return false;
            }

            if (s1.Length != s2.Length)
            {
                return false;
            }

            var s1chars = s1.ToCharArray();
            var s2chars = s2.ToCharArray();

            int hits = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1chars[i].Equals(s2chars[i]))
                {
                    hits += 2;
                }
                else
                {
                    hits += 1;
                }
            }

            bool same = (hits == s1.Length * 2);

            return same;
        }
    }
}
