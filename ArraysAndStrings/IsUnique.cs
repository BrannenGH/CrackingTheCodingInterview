namespace ArraysAndStrings
{
    public static class IsUnique
    {
        public static bool IsUniqueSolution(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = (i + 1); j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        return false;
                    } 
                }
            }
            return true;
        }
    }
}