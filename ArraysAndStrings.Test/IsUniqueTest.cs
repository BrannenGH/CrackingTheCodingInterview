using System;
using Xunit;

namespace ArraysAndStrings.Test
{
    public class IsUniqueTest
    {
        public IsUniqueTest()
        {
            _expected =  new []{
                Tuple.Create("ABC", true),
                Tuple.Create("AABC", false)
            };
        }

        private readonly Tuple<string, bool>[] _expected;

        [Fact]
        public void IsUniqueBruteForce()
        {
            foreach (var item in _expected)
            {
                Assert.Equal(item.Item2,IsUnique.IsUniqueSolution(item.Item1));
            }
        }
    }
}