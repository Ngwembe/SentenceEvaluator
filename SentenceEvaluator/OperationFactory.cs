using SentenceEvaluator.Models;

public class OperationFactory
{
    private static OperationFactory _operationFactory = null;
    private static readonly object factoryCreateLock = new object();

    public enum Operation : short { CheckForDuplicateLetters = 1, CheckForVowels = 2, CheckForVowelDominance = 3 }

    private OperationFactory() { }

    public static OperationFactory GetOperationFactory
    {
        get
        {
            lock (factoryCreateLock)
            {
                if (_operationFactory == null)
                    _operationFactory = new OperationFactory();
            }

            return _operationFactory;
        }
    }

    public IList<BaseOperation> Execute(string userInput)
    {
        var operations = new List<BaseOperation>();

        foreach (var option in userInput)
        {
            short currentOption = Convert.ToInt16(new string(option, 1));

            switch ((Operation)currentOption)
            {
                case Operation.CheckForDuplicateLetters:
                    operations.Add(new CheckTextForDuplicate());
                    break;

                case Operation.CheckForVowels:
                    operations.Add(new CheckTextForVowels());
                    break;

                case Operation.CheckForVowelDominance:
                    operations.Add(new CheckTextForVowelDominance());
                    break;
                default:
                    break;
            }
        }

        return operations;
    }
}
