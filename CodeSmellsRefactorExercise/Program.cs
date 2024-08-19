namespace CodeSmellsRefactorExercise
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var calculator = new Calculator();
			calculator.Run();
		}
	}

	public class Calculator
	{
		private List<int> numbers = new List<int>();

		public void Run()
		{
			Console.WriteLine("Enter numbers separated by spaces:");
			var input = Console.ReadLine();

			if (string.IsNullOrEmpty(input))
			{
				Console.WriteLine("No input provided.");
				return;
			}

			var numList = input.Split(' ');
			foreach (var n in numList)
			{
				numbers.Add(int.Parse(n));
			}

			var sum = 0;
			foreach (var number in numbers)
			{
				sum += number;
			}

			var average = sum / numbers.Count;

			if (numbers.Count > 0 && sum > 0 && average > 0)
			{
				Console.WriteLine($"Sum: {sum}");
				Console.WriteLine($"Average: {average}");
			}

			Console.WriteLine("Program finished.");
		}
	}
}
