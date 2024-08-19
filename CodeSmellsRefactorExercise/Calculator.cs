namespace CodeSmellsRefactorExercise;

public class Calculator
{
    private List<int> numbers = new List<int>();

    public void Run()
    {
        GetUserInput();
        double sum = GetSum();
        double average = GetAverage(sum);
        DisplayResults(sum, average);

        Console.WriteLine("Program finished.");
    }

    private List<int> GetUserInput()
    {
        Console.WriteLine("Enter numbers separated by spaces:");
        var input = Console.ReadLine();

        if (string.IsNullOrEmpty(input))
        {
            throw new ArgumentException("No input provided.");
        }

        var numList = input.Split(' ');
        foreach (var n in numList)
        {
            numbers.Add(int.Parse(n));
        }

        return numbers;
    }

    private double GetSum()
    {
        if (numbers.Count == 0)
        {
            throw new ArgumentException("No numbers to calculate.");
        }

        double sum = 0;
        foreach (var number in numbers)
        {
            sum += number;
        }
        return sum;
    }

    private double GetAverage(double sum)
    {
        double average = sum / numbers.Count;
        return average;
    }

    private void DisplayResults(double sum, double average)
    {
        if (numbers.Count == 0)
        {
            throw new ArgumentException("No results to display.");
        }

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {average}");
    }
}