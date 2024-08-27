using CodeSmellsRefactorExercise.Interfaces;

namespace CodeSmellsRefactorExercise.Models
{
    public class Calculator
    {
        private readonly List<int> numbers;
        private readonly IInputReader inputReader;
        private readonly IFormatter formatter;

        public int Sum { get; set; }
        public double Average { get; set; }

        public Calculator(IInputReader inputReader, IFormatter formatter)
        {
            this.numbers = new List<int>();
            this.inputReader = inputReader;
            this.formatter = formatter;
        }

        public void RunCalculator()
        {
            string input = inputReader.NumbersReader();
            formatter.NumberSplitter(input, numbers);

            this.Sum = AverageCalculator().Item1;
            this.Average = AverageCalculator().Item2;

            Result(this.Sum, this.Average);
        }


        public (int, double) AverageCalculator()
        {
            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            var average = sum / numbers.Count;
            return (sum, average);
        }


        public void Result(int sum, double average)
        {
            if (isResultValid(this))
            {
                Console.WriteLine($"Sum: {sum}");
                Console.WriteLine($"Average: {average}");
            }
        }

        private bool isResultValid(Calculator calc)
        {
            return calc.numbers.Count > 0 && calc.Sum > 0 && calc.Average > 0;
        }
    }

}