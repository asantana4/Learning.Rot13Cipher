using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Rot13Cipher
{
    public class Rot13Cipher
    {
        public string TransformMessage(string input)
        {

            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }

            //StringBuilder finalMessage = new StringBuilder();
            char[] rotChars = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                int currChar = input[i];

                if ((input[i] >= 'a' && input[i] <= 'm') || (input[i] >= 'A' && input[i] <= 'M')) 
                {
                    currChar += 13;

                } else if ((input[i] >= 'n' && input[i] <= 'z') || (input[i] >= 'N' && input[i] <= 'Z')) 
                {
                    currChar -= 13;
                }

                rotChars[i] = (char) currChar;

            }
            return new string(rotChars);
        }

    }
}
