using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenceEvaluator.Models
{
    public class CheckTextForVowels : BaseOperation, ICheckTextForVowels
    {
        private List<char> vowelsFound;

        public CheckTextForVowels()
        {
            vowelsFound = new List<char>();
        }

        public string CheckForVowels(string textToAnalyse)
        {       
            var analysedText = textToAnalyse.Replace(" ", "").ToLower().Distinct().ToList();

            foreach (var letter in analysedText)
            {
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                    vowelsFound.Add(letter);
            }         
            
            return vowelsFound.Any() ? $"The number of vowels is {vowelsFound.Count}" : "No vowels were found";
        }

        public override void Print(string textToAnalyse)
        {
            var report = CheckForVowels(textToAnalyse);
            
            Console.WriteLine(report);
        }
    }
}
