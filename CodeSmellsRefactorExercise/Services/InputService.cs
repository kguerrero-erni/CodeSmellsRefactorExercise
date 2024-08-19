using CodeSmellsRefactorExercise.Interfaces;

namespace CodeSmellsRefactorExercise.Services;

public class InputService : IInputService
{

    public string GetInput()
    {
        Console.WriteLine("Enter numbers separated by spaces:");
        string input = Console.ReadLine() ?? string.Empty;

        if (string.IsNullOrEmpty(input))
        {
            throw new ArgumentException("Error: Input is empty");
        }

        return input;
    }

    public List<double> ParseNumbers(string input)
    {

        var numList = input.Split(' ');
        var numbers = new List<double>();

        foreach (var n in numList)
        {
            bool isNumber = double.TryParse(n, out var number);

            if (!isNumber)
            {
                throw new ArgumentException($"Error: \"{n}\" Input is not a number");
            }

            numbers.Add(number);

        }

        return numbers;
    }
}