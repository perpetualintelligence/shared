/*
    Copyright (c) 2023 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace OneImlx.Shared.Licensing
{
    public class X509CertificateFixture : IDisposable
    {
        public X509Certificate2 Certificate { get; }

        public X509CertificateFixture()
        {
            Certificate = GenerateTestCertificate();
        }

        public void Dispose()
        {
            Certificate?.Dispose();
        }

        private static X509Certificate2 GenerateTestCertificate()
        {
            using var rsa = RSA.Create(2048);
            var request = new CertificateRequest("cn=TestCertificate", rsa, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
            return request.CreateSelfSigned(DateTimeOffset.Now, DateTimeOffset.Now.AddYears(1));
        }
    }
}