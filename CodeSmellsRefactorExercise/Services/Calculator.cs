using CodeSmellsRefactorExercise.Interfaces;

namespace CodeSmellsRefactorExercise.Services;
public class Calculator : ICalculator
{
    private List<double> numbers = new List<double>();

    private readonly IInputService _inputParser;

    public Calculator(IInputService inputParser)
    {
        _inputParser = inputParser;
    }

    public void Run()
    {
        var input = _inputParser.GetInput();

        numbers = _inputParser.ParseNumbers(input);

        Console.WriteLine($"Sum: {Sum(numbers)}");
        Console.WriteLine($"Average: {Average(Sum(numbers), numbers.Count)}");

    }
    public double Sum(List<double> numbers)
    {
        if (numbers.Count == 0)
        {
            throw new ArgumentException("List is Empty");
        }

        return numbers.Sum();
    }

    public double Average(double sum, int count)
    {
        if (!(count > 0 && sum > 0))
        {
            throw new ArgumentException("Error: Sum or Count is Zero");
        }

        return sum / count;
    }

}