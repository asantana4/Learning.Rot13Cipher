using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Rot13Cipher.Tests
{
    public class Rot13CipherTests
    {
        [Theory]
        [InlineData("call", "pnyy")]
        [InlineData("high", "uvtu")]
        [InlineData("pybpx", "clock")]
        [InlineData("uvtu", "high")]
        [InlineData("Computer", "Pbzchgre")]
        [InlineData("FBF!", "SOS!")]
        [InlineData("Rot13Cipher", "Ebg13Pvcure")]
        [InlineData("56.!*+", "56.!*+")]

        public void EncryptDecryptText_GivenValidStringMessage_ReturnsExpectedEncryptedDecryptedString(string input, string expected)
        {
            //// 1. ARRANGE
            //// Create the input data and the expected output
            //string input = "GCTA";
            //string expectedString = "CGAU";

            // 2. ACT
            // Call the actual method being tested
            var encrypter = new Rot13Cipher();
            string actualString = encrypter.TransformMessage(input);

            // 3. ASSERT
            // Verify the output matches expectations
            Assert.Equal(expected, actualString);
        }

        [Fact]
        public void EncryptDecryptText_GivenEmptyString_ReturnsEmptyString()
        {
            // 1.ARRANGE
            // Create the input data and the expected output
            string input = "";
            string expectedString = "";
            //DnaStrandType strandType = DnaStrandType.Coding;

            // 2. ACTt
            // Call the actual method being tested
            var encrypter = new Rot13Cipher();
            string actualString = encrypter.TransformMessage(input);


            // 3. ASSERT
            // Verify the output matches expectations
            Assert.Equal(expectedString, actualString);

        }

        [Fact]
        public void EncryptDecryptText_GivenNullValue_ReturnsEmptyString()
        {
            // 1.ARRANGE
            // Create the input data and the expected output
            string? input = null;
            string expectedString = "";
            //DnaStrandType strandType = DnaStrandType.Coding;

            // 2. ACTt
            // Call the actual method being tested
            var encrypter = new Rot13Cipher();
            string actualString = encrypter.TransformMessage(input!);


            // 3. ASSERT
            // Verify the output matches expectations
            Assert.Equal(expectedString, actualString);

        }

    }
}
