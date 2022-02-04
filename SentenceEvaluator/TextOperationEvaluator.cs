using SentenceEvaluator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenceEvaluator
{
    public class TextOperationEvaluator
    {
        public void EvaluateText(string textToAnalyse, params BaseOperation[] operations) 
        {
            foreach(var operation in operations)
            {
                operation.Print(textToAnalyse);
            }
        }
    }
}
