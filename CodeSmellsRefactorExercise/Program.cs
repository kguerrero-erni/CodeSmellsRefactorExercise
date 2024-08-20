namespace CodeSmellsRefactorExercise
{
	internal class Program
	{
        public static IList<double> InputProvider(string input, IInputDataConverter inputDataConverter)
        {
            // IList<double> numList = _inputConverter.StringToDoubleList(input);

            // can be its own error
            if (string.IsNullOrEmpty(input))
            {
                throw new EmptyInputException("No Input Provided");
            }
            try
            {
                return inputDataConverter.StringToDoubleList(input);
            }
            catch (InvalidInputException ex)
            {
                throw new InvalidInputException("Invalid Input or Format", ex);
            }
        }

        static void Main(string[] args)
		{
			IOperations operations = new Operations();
            IInputDataConverter inputDataConverter = new InputDataConverter();

            // add error handling here
            Console.WriteLine("Enter numList separated by spaces:");
            string input = Console.ReadLine();

            try
            {
                IList<double> numList = InputProvider(input, inputDataConverter);

                // use an interface
                var calculator = new Calculator(operations);
                calculator.RunCalculation(numList);
            }
            catch (InvalidInputException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (EmptyInputException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (OutputIsZeroException ex)
            {
                Console.WriteLine($"Notable Result: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
	}


}
