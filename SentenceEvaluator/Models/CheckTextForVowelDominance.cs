namespace SentenceEvaluator.Models
{
    public class CheckTextForVowelDominance : BaseOperation, ICheckTextForVowelDominance
    {
        private int vowelCounter = 0;
        private int nonVowelCounter = 0;

        public override void Print(string textToAnalyse)
        {
            string report = CheckForVowelsDominance(textToAnalyse);            
            
            Console.WriteLine(report);
        }

        public string CheckForVowelsDominance(string textToAnalyse)
        {
            var analysedText = textToAnalyse.Replace(" ", "").ToLower().ToList();

            foreach (var letter in analysedText)
            {
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                    vowelCounter++;
                else
                    nonVowelCounter++;
            }

            if (vowelCounter == nonVowelCounter)
                return "The text has an equal amount of vowels and non vowels";
            else
                return vowelCounter > nonVowelCounter ? "The text has more vowels than non vowels" : "The text has more non vowels than vowels";
        }
    }
}
