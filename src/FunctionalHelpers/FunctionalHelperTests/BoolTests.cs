using FluentAssertions;
using System.Linq;
using Xunit;
using static FunctionalHelpers.Bool;

namespace FunctionalHelperTests
{
    // Random tests in random order, didn't have time to sort and name them
    public class BoolTests
    {
        [Fact]
        public void NotTests()
        {
            {
                var notIsNullOrEmptyFunc = Not<string?>(string.IsNullOrEmpty);

                notIsNullOrEmptyFunc(null).Should().BeFalse();
                notIsNullOrEmptyFunc("").Should().BeFalse();
                notIsNullOrEmptyFunc("abc").Should().BeTrue();
            }

            {
                (new string?[] { "a", "b", "c" }).All(Not<string?>(string.IsNullOrEmpty)).Should().BeTrue();
            }
        }

        [Fact]
        public void AndTests()
        {
            {
                // int.TryParse probably includes !string.IsNullOrEmpty check, but this is to test And
                var looksLikeIntFunc =
                    And(Not<string?>(string.IsNullOrEmpty), CanBeParsedAsInt);

                looksLikeIntFunc(null).Should().BeFalse();
                looksLikeIntFunc("").Should().BeFalse();
                looksLikeIntFunc("abc").Should().BeFalse();
                looksLikeIntFunc("1abc").Should().BeFalse();
                looksLikeIntFunc("1234").Should().BeTrue();
                looksLikeIntFunc("-1").Should().BeTrue();
            }
        }

        [Fact]
        public void OrTests()
        {
        }

        [Fact]
        public void XorTests()
        {
        }

        private static bool CanBeParsedAsInt(string? str) =>
            int.TryParse(str, out var _);
    }
}