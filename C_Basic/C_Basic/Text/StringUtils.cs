using System;
using System.Collections.Generic;

namespace C_Basic.Text
{
    public static class StringUtils
    {
        public static string LimitString(string str, int th = 144)
        {
            if (str.Length <= th)
            {
                Console.WriteLine("Text is not changed");
                return str;
            }

            var words = str.Split(' ');
            var totalChars = 0;
            var textWords = new List<string>();

            foreach (var word in words)
            {
                totalChars += (word.Length + 1);

                if (totalChars <= th)
                {
                    textWords.Add(word);
                }

                if (totalChars > th)
                    break;
            }

            Console.WriteLine("Text is modified");

            return String.Join(" ", textWords) + "...";
        }
    }
}
