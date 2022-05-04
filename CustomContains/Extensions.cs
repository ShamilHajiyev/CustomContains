using System;
using System.Collections.Generic;
using System.Text;

namespace CustomContains
{
    static class Extensions
    {
        public static bool CustomCont(this string sentence, string word)
        {
            sentence = sentence.ToLower();
            word = word.ToLower();
            StringBuilder found = new StringBuilder();

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < sentence.Length; j++)
                {
                    if (sentence[j] == word[i])
                    {
                        found.Append(sentence[j]);
                        sentence = sentence.Remove(0, j + 1);
                        break;
                    }
                    else if (i > 0 && found.Length > 0)
                    {
                        found.Remove(0, 1);
                        i--;
                    }
                }
            }
            
            if (word == found.ToString())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
