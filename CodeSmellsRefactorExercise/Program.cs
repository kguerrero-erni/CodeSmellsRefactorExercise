using CodeSmellsRefactorExercise.Services;

namespace CodeSmellsRefactorExercise
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var calculatorInput = new InputService();
			var calculator = new Calculator(calculatorInput);

			try
			{
				calculator.Run();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			finally
			{
				Console.WriteLine("Program finished.");
			}
		}
	}

}
