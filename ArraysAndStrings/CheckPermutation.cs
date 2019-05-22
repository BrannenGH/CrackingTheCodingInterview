using System.Collections.Generic;
using System.Linq;

namespace ArraysAndStrings
{
    public static class CheckPermutation
    {
        public static bool CheckPermutationSolution(string original, string other)
        {
            var characters = new Dictionary<char, CharInfo>();
            ;
            foreach (var character in original)
                if (characters.ContainsKey(character))
                    characters[character].count++;
                else
                    characters[character] = new CharInfo {character = character, count = 1};

            foreach (var character in other)
                if (!characters.ContainsKey(character))
                    return false;
                else
                    characters[character].count--;

            return characters.Values.All(charInfo => charInfo.count == 0);
        }

        public class CharInfo
        {
            public char character;
            public int count;
        }
    }
}