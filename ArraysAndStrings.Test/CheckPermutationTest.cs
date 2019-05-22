using System;
using Xunit;

namespace ArraysAndStrings.Test
{
    public class CheckPermutationTest
    {
        public CheckPermutationTest()
        {
            _expected = new[]
            {
                Tuple.Create("abc", "efg", false),
                Tuple.Create("abc", "abc", true),
                Tuple.Create("", "", true),
                Tuple.Create("bca", "abc", true),
                Tuple.Create("bc", "abc", false),
                Tuple.Create("abc", "cb", false)
            };
        }

        private readonly Tuple<string, string, bool>[] _expected;

        [Fact]
        public void CheckPermutationSolution()
        {
            foreach (var item in _expected)
                Assert.Equal(item.Item3,
                    CheckPermutation.CheckPermutationSolution(item.Item1, item.Item2));
        }
    }
}