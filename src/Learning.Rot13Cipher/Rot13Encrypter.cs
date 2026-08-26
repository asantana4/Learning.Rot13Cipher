using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Rot13Cipher
{
    public class Rot13Encrypter
    {
        public string ObfuscateText(string input)
        {

            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }

            StringBuilder finalMessage = new StringBuilder();
            foreach (char c in input)
            {
                int charIntValue = c;
                
                if ((c >= 'a' && c <= 'm') || (c >= 'A' && c <= 'M')) 
                {
                    charIntValue += 13;

                } else if ((c >= 'n' && c <= 'z') || (c >= 'N' && c <= 'Z')) 
                {
                    charIntValue -= 13;
                } 

                finalMessage.Append((char)charIntValue);

            }
            return finalMessage.ToString();
        }

    }
}
