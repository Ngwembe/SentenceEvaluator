using SentenceEvaluator;
using SentenceEvaluator.Models;
using static OperationFactory;

string textToAnalyse =  //"Albert suck"; 
                        "I ate apples";
//"I like to eat apples";
//"I like eating apples";
//"rhythm";

Console.Write("Enter which operations to do on the supplied text: ");
string operationSelection = Console.ReadLine() ?? string.Empty;


var factory = OperationFactory.GetOperationFactory;
var operations = factory.Execute(operationSelection);

var textEvaluator = new TextOperationEvaluator();

textEvaluator.EvaluateText(textToAnalyse, operations.ToArray());


Console.ReadKey();