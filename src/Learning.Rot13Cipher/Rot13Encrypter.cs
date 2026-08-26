using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Rot13Cipher
{
    public class Rot13Encrypter
    {
        public string EncryptDecryptText(string input)
        {

            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }

            StringBuilder finalMessage = new StringBuilder();
            foreach (char c in input)
            {
                int charIntValue = c;
                
                if ((c >= 97 && c <= 109) || (c >= 65 && c <= 77)) 
                {
                    charIntValue += 13;

                } else if ((c >= 110 && c <= 122) || (c >= 78 && c <= 90)) 
                {
                    charIntValue -= 13;
                } 

                finalMessage.Append((char)charIntValue);

            }
            return finalMessage.ToString();
        }

    }
}
