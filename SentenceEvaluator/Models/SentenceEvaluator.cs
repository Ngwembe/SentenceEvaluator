using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenceEvaluator.Models
{
    public class SentenceEvaluator: IPromptTextSelectionStage, ICheckDuplicateSelectionStage
    {
        private SentenceEvaluator() { }

        public static IPromptTextSelectionStage PromptUserText() { return new SentenceEvaluator(); }

        ICheckDuplicateSelectionStage IPromptTextSelectionStage.CheckDuplicateLetters(string sentence)
        {
            throw new NotImplementedException();
        }
    }

    public interface IPromptTextSelectionStage
    {
        public ICheckDuplicateSelectionStage CheckDuplicateLetters(string sentence);
    }

    public interface ICheckDuplicateSelectionStage
    {
    }
}
