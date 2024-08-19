public class Calculator
	{

		private List<int> numbers = new List<int>();

		public void Run()
		{
			ConditionalErrorException();
			OutputMethod();

			Console.WriteLine("Program finished.");
		}

		private void ConditionalErrorException()
		{
			Console.WriteLine("Enter numbers separated by spaces:");
			var input = Console.ReadLine();
           
            if (string.IsNullOrWhiteSpace(input))
			{
				throw new ArgumentException("Invalid Input", input);
			}

			var numList = input.Split(' ');
			foreach (var n in numList)
			{
				numbers.Add(int.Parse(n));
			}
		}

       
		private void OutputMethod()
        {
	        var sum = 0;
			foreach (var number in numbers)
			{
				sum += number;
			}

			var average = sum / numbers.Count;

			if (Value(sum, average))
			{
				Console.WriteLine($"Sum: {sum}");
				Console.WriteLine($"Average: {average}");
			}
		}
        
		public bool Value(int sum, int average)
		{
			
            return numbers.Count>0 && sum>0 && average>0;
			
		}	
	}