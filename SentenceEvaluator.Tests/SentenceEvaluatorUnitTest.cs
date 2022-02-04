using Xunit;

namespace SentenceEvaluator.Tests
{
    public class SentenceEvaluatorUnitTest
    {
        [Fact]
        public void OperationFactory_DetermineOperationToPerform_ReturnsTrue()
        {
            string userInput = "1";
            //string userInput = "I ate apples";

            var factory = OperationFactory.GetOperationFactory;
            var operations = factory.Execute(userInput);

            Assert.Single(operations);
        }

        [Fact]
        public void OperationFactory_DetermineOperationToPerform_ReturnsFalse()
        {
            string userInput = "12";
            //string userInput = "I ate apples";

            var factory = OperationFactory.GetOperationFactory;
            var operations = factory.Execute(userInput);

            Assert.False(operations.Count == 1);
        }

        [Fact]
        public void CheckForVowelsDominance_DeterminesIfTextHasMoreVowelThanNonVowelLetters_ReturnsEqualCount()
        {
            string textToAnalyse = "I ate apples";

            var vowelDominanceCheck = new SentenceEvaluator.Models.CheckTextForVowelDominance();

            var result = vowelDominanceCheck.CheckForVowelsDominance(textToAnalyse);

            Assert.Equal(expected: "The text has an equal amount of vowels and non vowels", result);
        }

        [Fact]
        public void CheckForVowelsDominance_DeterminesIfTextHasMoreVowelThanNonVowelLetters_ReturnsFalse()
        {
            string textToAnalyse = "John ran";

            var vowelDominanceCheck = new SentenceEvaluator.Models.CheckTextForVowelDominance();

            var result = vowelDominanceCheck.CheckForVowelsDominance(textToAnalyse);
            
            Assert.Equal(expected: "The text has more non vowels than vowels", result);
        }
        
        [Fact]
        public void CheckForVowelsDominance_DeterminesIfTextHasMoreVowelThanNonVowelLetters_ReturnsTrue()
        {
            string textToAnalyse = "Joe ate an eel";

            var vowelDominanceCheck = new SentenceEvaluator.Models.CheckTextForVowelDominance();

            var result = vowelDominanceCheck.CheckForVowelsDominance(textToAnalyse);

            Assert.Equal(expected:  "The text has more vowels than non vowels", result);
        }

        [Fact]
        public void CheckForDuplicateLetters_DeterminesIfThereAreDuplicateLetters_ReturnsTrue()
        {
            string textToAnalyse = "Joe ate an eel";

            var duplicateCheck = new SentenceEvaluator.Models.CheckTextForDuplicate();

            var result = duplicateCheck.CheckForDuplicateLetters(textToAnalyse);

            Assert.Equal(expected: "EA", result);
        }
        
        [Fact]
        public void CheckForDuplicateLetters_DeterminesIfThereAreDuplicateLetters_ReturnsFalse()
        {
            string textToAnalyse = "asdfglhkj";

            var duplicateCheck = new SentenceEvaluator.Models.CheckTextForDuplicate();

            var result = duplicateCheck.CheckForDuplicateLetters(textToAnalyse);

            Assert.Equal(expected: "No duplicate values were found", result);
        }

        [Fact]
        public void CheckForVowels_DeterminesIfTextHasVowels_ReturnsTrue()
        {
            string textToAnalyse = "I like eating apples";

            var vowelsCheck = new SentenceEvaluator.Models.CheckTextForVowels();

            var result = vowelsCheck.CheckForVowels(textToAnalyse);

            Assert.Equal(expected: "The number of vowels is 3", result);
        }

        [Fact]
        public void CheckForVowels_DeterminesIfTextHasVowels_ReturnsFalse()
        {
            string textToAnalyse = "jkl kkjh";

            var vowelsCheck = new SentenceEvaluator.Models.CheckTextForVowels();

            var result = vowelsCheck.CheckForVowels(textToAnalyse);

            Assert.Equal(expected: "No vowels were found", result);
        }
    }
}