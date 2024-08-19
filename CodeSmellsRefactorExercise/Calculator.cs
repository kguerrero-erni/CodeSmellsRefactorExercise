namespace CodeSmellsRefactorExercise;
public class Calculator
{
    private List<int> numbers = new List<int>();

    public void Run()
    {
        try
        {
            Console.WriteLine("Enter numbers separated by spaces:");
            var input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException("Null input");
            }

            ParseStringtoInt(input);
            int sum = AddSum();
            var average = sum / numbers.Count;

            if (IsZero(numbers.Count, sum, average))
            {
                Console.WriteLine($"Sum: {sum}");
                Console.WriteLine($"Average: {average}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Program finished.");
        }
    }

    public static bool IsZero(int numbers, int sum, int average)
    {
        return numbers > 0 && sum > 0 && average > 0;
    }

    public int AddSum()
    {
        var sum = 0;
        foreach (var number in numbers)
        {
            sum += number;
        }

        return sum;
    }

    public List<int> ParseStringtoInt(string input)
    {
        var numList = input.Split(' ');
        foreach (var n in numList)
        {
            numbers.Add(int.Parse(n));
        }
        return numbers;
    }
}