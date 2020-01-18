using System.Collections.Generic;

public class StringPermutation
{
    public List<string> Permutate(string str)
    {
        var result = new List<string>();

        Permutate("", str, result);

        return result;
    }

    private void Permutate(string prefix, string str, List<string> result)
    {
        var strLength = str.Length;

        if (strLength == 0)
            result.Add(prefix);
        else
        {
            for (int i = 0; i < strLength; i++)
            {
                var iStr = prefix + str[i];
                var iPrefix = str.Substring(0, i) + str.Substring(i + 1, strLength - (i + 1));

                Permutate(iStr, iPrefix, result);
            }
        }
    }

    /// <summary>
    /// Count of all permutations of the shorter string 'str' within the longer one 'text'
    /// </summary>
    public int GetPermutationCount(string str, string text)
    {
        var possiblePermutations = new HashSet<string>(Permutate(str));

        var permutationCount = 0;

        for (int i = 0; i <= text.Length - str.Length; i++)
        {
            var current = text.Substring(i, str.Length);

            if (possiblePermutations.Contains(current))
                permutationCount++;
        }

        return permutationCount;
    }
}