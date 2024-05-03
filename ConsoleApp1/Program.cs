using ConsoleApp1.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var sentence = "This is going to be a really really really really really really long test";
            int MxLength = 20;
            if(sentence.Length<MxLength)
                Console.WriteLine(sentence);
            else
            {
                var words = sentence.Split(' ');
                var totalCharacter = 0;

                var summaryWords = new List<string>();

                foreach(var word in words)
                {
                    totalCharacter += word.Length;

                    summaryWords.Add(word);
                    if(totalCharacter > MxLength)
                    {
                        
                        break;
                    }
                }
                var summary = String.Join(" ", summaryWords) + "...";
                Console.WriteLine("summary: "+summary);

            }


            Console.ReadLine();
        }

        
    }
}
