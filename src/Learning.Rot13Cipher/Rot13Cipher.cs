using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace Learning.Rot13Cipher
{
    public class Rot13Cipher
    {
        private const int Offset = 13;
        private const int AlphabetLength = 26;

        public static string TransformMessage(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input), "Input to cipher cannot be null.");
            }

            if (input.Length == 0)
            {
                return string.Empty;
            }
       
            char[] resultCharacters = new char[input.Length];    

            for (int i = 0; i < input.Length; i++)
            {
                char originalCharacter = input[i];
                char finalCharacter = originalCharacter;           

                if (isEnglishLetter(originalCharacter)) 
                {
                    char baseLetter = char.IsUpper(originalCharacter) ? 'A' : 'a';
                    finalCharacter = (char)(((originalCharacter - baseLetter + Offset) % AlphabetLength) + baseLetter);
                }
               
                resultCharacters[i] = finalCharacter;
            }

            return new string(resultCharacters);
        }

        private static bool isEnglishLetter(char c)
        {
            return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z');
        }

    }
}
