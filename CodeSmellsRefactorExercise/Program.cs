namespace CodeSmellsRefactorExercise
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//tight coupling
			var calculator = new Calculator();
			calculator.Run();
		}
	}
}
