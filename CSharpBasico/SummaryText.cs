using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasico
{
    class SummaryText
    {
        static void Main(string[] args)
        {
            // POST = C# se actualiza a su nuerva versión

            // PREVIEW: Este es un mensaje del preview del texto dentro...

            var sentence = "Este es un mensaje del preview del texto dentro del post que habla sobre la nueva version de c#.";

            Console.WriteLine(Summarize(sentence, 25));
            Console.WriteLine(Summarize(sentence, 20));
            Console.WriteLine(Summarize(sentence, 30));
            Console.WriteLine(Summarize(sentence, 31));


        }

        public static string Summarize(string sentence, int maxLength)
        {

            if (sentence.Length < maxLength)
                return sentence;
            else
            {

                var words = sentence.Split(' ');
                var totalCharacters = 0;

                var summaryWords = new List<string>();

                foreach (var word in words)
                {
                    summaryWords.Add(word);

                    totalCharacters += word.Length + 1;

                    if (totalCharacters > maxLength)
                        break;

                }

                var summary = string.Join(" ", summaryWords) + "...";

                return summary;

            }
        }
    }
}
