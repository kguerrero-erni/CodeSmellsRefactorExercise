using CodeSmellsRefactorExercise.Interface;

namespace CodeSmellsRefactorExercise;

public class Calculator : ICalculator
{
    private List<int> numbers = new List<int>();

    private IOperation _operation;
    private IParse _parse;
    

    public Calculator(IOperation operation, IParse parse)
    {
        _operation = operation;
        _parse = parse;
    }

    public void Run()
    {
        try
        {
            Console.WriteLine("Enter numbers separated by spaces:");
            string? input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException("string is empty");
            }

            _parse.ParseToList(input, numbers);
            
            double sum = _operation.GetSum(numbers);
            double average = _operation.GetAverage(sum, numbers.Count);

            if (isValueValid(numbers.Count, sum, average))
            {
                Console.WriteLine($"Sum: {sum}");
                Console.WriteLine($"Average: {average}");
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine("ERROR: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Program finished.");
        }
    }
    public bool isValueValid(int numbers, double sum, double average)
    {
        return numbers > 0 && sum > 0 && average > 0;
    }

}
