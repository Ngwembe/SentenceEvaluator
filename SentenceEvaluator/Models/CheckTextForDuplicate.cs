using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenceEvaluator.Models
{
    public class CheckTextForDuplicate : BaseOperation, ICheckTextForDuplicate
    {
        private IList<char> _duplicateLetters;

        public CheckTextForDuplicate()
        {
            _duplicateLetters = new List<char>();
        }

        public string CheckForDuplicateLetters(string textToAnalyse)
        {
            var characterArray = textToAnalyse.Replace(" ", "").ToUpper().ToCharArray();

            _duplicateLetters = characterArray
                .GroupBy(x => x).Where(i => i.Count() > 1).Select(x => x.Key).ToList();

            return _duplicateLetters.Any() ? String.Join("", _duplicateLetters.ToArray()) : "No duplicate values were found";
        }

        public override void Print(string textToAnalyse)
        {
            var report = CheckForDuplicateLetters(textToAnalyse);

            Console.WriteLine(report);
        }
    }
}
