using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Smith
{
    class PigGreekTranslator : ITranslatable
    {
        //overloaded translate method from interface to translate into pig greek
        public string Translate(string sentence)
        {
            if (sentence == "")
            {
                throw new NotImplementedException();
            }
            else
            {
                const string vowels = "AEIOUaeio";
                List<string> newWords = new List<string>();

                foreach (string word in sentence.Split(' '))
                {
                    string firstLetter = word.Substring(0, 1);
                    string restOfWord = word.Substring(1, word.Length - 1);
                    int currentLetter = vowels.IndexOf(firstLetter);

                    if (currentLetter == -1)
                    {
                        newWords.Add(restOfWord + firstLetter + "omatos");
                    }
                    else
                    {
                        newWords.Add(word + "oi");
                    }
                }
                return string.Join(" ", newWords);
            }
        }
    }
}
