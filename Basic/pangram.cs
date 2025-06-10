/*
A pangram is a string that contains every letter of the alphabet. Given a sentence determine whether it is a pangram in the English alphabet. 
Ignore case. Return either pangram or not pangram as appropriate.
*/
using System;

public class Pangram
{
    public static string pangrams(string s)
    {
        var characters = s.ToLower().ToCharArray();
        var reverseIndex = characters.Length - 1;
        var alphaArray = new int[26];
        var totalKeyFound = 0;

        var processCharAscii = (int index, char character, int charAscii) =>
        {
            if (character != ' ' && alphaArray[index] == 0)
            {
                totalKeyFound++;
                alphaArray[index] = charAscii;
            }
        };

        for (var i = 0; i < characters.Length; i++)
        {
            var leftCharAsci = (int)characters[i];
            processCharAscii(leftCharAsci - 97, characters[i], leftCharAsci);

            if (i >= reverseIndex || totalKeyFound == 26)
            {
                break;
            }

            var rightCharAsci = (int)characters[reverseIndex];
            processCharAscii(rightCharAsci - 97, characters[reverseIndex], rightCharAsci);

            reverseIndex--;
        }

        return totalKeyFound == 26 ? "pangram" : "not pangram";
    }
    public static void Main()
    {
        string result = Pangram.pangrams("We promptly judged antique ivory buckles for the prize");
        Console.WriteLine(result);

        string result1 = Pangram.pangrams("the quick brown fox jumnps over a lazy dog");
        Console.WriteLine(result1);
    }
}
