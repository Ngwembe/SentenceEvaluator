using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenceEvaluator.Models
{
    public abstract class BaseOperation
    {
        public virtual void Print(string textToAnalyse) => Console.WriteLine("Base Print");
    }
}
