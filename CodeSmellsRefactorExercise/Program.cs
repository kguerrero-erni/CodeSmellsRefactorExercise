using System.Diagnostics.CodeAnalysis;
using CodeSmellsRefactorExercise.Models;

namespace CodeSmellsRefactorExercise
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var inputReader = new InputReader();
			var formatter = new Formatter();
			var calculator = new Calculator(inputReader, formatter);

			try
			{
				calculator.RunCalculator();
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
	}
}
