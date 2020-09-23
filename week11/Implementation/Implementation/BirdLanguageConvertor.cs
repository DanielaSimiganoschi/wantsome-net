using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
namespace UnitTesting.Implementation
{
    public class BirdLanguageConverter
    {
        List<char> vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
        char connectionLetter = 'p';
        public string Convert(string phrase)
        {
            var sb = new StringBuilder();
            foreach (var letter in phrase)
            {
                sb.Append(letter);
                if (vowels.Contains(char.ToLower(letter)))
                {
                    sb.Append(connectionLetter);
                    sb.Append(letter);
                }
            }
            return sb.ToString();
        }
    }
}