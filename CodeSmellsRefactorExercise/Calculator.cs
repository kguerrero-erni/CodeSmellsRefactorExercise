namespace CodeSmellsRefactorExercise
{
    public class Calculator : ICalculator
    {
        private readonly IOperations _operations;

        public Calculator( IOperations operations)
        {
            _operations = operations;
        }

        public bool ValidateNumCountIsNotZero(IList<double> numList, double sum, double average)
        {
            return numList.Count > 0
                   && sum > 0
                   && average > 0;
        }

        public void RunCalculation(IList<double> numList)
        {
            double sum = _operations.Sum(numList);

            double average = _operations.Average(numList, sum);

            if (ValidateNumCountIsNotZero(numList, sum, average))
            {
                Console.WriteLine($"Sum: {sum}");
                Console.WriteLine($"Average: {average}");
            } else
            {
                throw new OutputIsZeroException("Sum and Average are 0");
            }

            Console.WriteLine("Program finished.");
        }

    }
}
