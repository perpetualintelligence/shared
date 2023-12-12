/*
    Copyright (c) 2023 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using FluentAssertions;
using System;
using Xunit;

namespace OneImlx.Shared.Infrastructure
{
    public class TryResultErrorTests
    {
        [Fact]
        public void TryResultNullErrorShouldError()
        {
#pragma warning disable CA1806 // Do not ignore method results
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
            Action act = () => new TryResultOrError<object>(error: null);
            act.Should().Throw<ArgumentNullException>().WithMessage("Value cannot be null. (Parameter 'error')");
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
#pragma warning restore CA1806 // Do not ignore method results
        }

        [Fact]
        public void TryResultNullResultShouldError()
        {
#pragma warning disable CA1806 // Do not ignore method results
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
            Action act = () => new TryResultOrError<object>(result: null);
            act.Should().Throw<ArgumentNullException>().WithMessage("Value cannot be null. (Parameter 'result')");
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
#pragma warning restore CA1806 // Do not ignore method results
        }
    }
}