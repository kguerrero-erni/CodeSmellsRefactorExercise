namespace CodeSmellsRefactorExercise
{
    public class Calculator
    {

        private List<int> numbers = new List<int>();

        public void Run()
        {
            Console.WriteLine("Enter numbers separated by spaces:");
            var input = Console.ReadLine();

            //lack of error handling
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException("No input provided.");

            }

            var numbers = ParseStringtoInt(input);

            var sum = AddSum();

            var average = sum / numbers.Count;

            // conditional complexity
            // if (numbers.Count > 0 && sum > 0 && average > 0)
            if (CheckSumAndAverage(sum, average, numbers.Count))
            {
                Console.WriteLine($"Sum: {sum}");
                Console.WriteLine($"Average: {average}");
            }

            Console.WriteLine("Program finished.");
        }

        private bool CheckSumAndAverage(int sum, int average, int numbers)
        {
            return numbers > 0 && sum > 0 && average > 0;
        }

        private List<int> ParseStringtoInt(string input)
        {
            var numList = input.Split(' ');

            foreach (var n in numList)
            {
                numbers.Add(int.Parse(n));
            }
            return numbers;


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

    }
}
