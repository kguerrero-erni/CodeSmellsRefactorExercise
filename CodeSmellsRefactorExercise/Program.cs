namespace CodeSmellsRefactorExercise
{
	public class Program
	{
		static void Main(string[] args)
		{
			var parse = new Parse();
			var operation = new Operation();
			var calculator = new Calculator(operation, parse);
			calculator.Run();
		}
	}

}
