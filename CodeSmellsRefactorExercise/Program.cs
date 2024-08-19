using System.Security.Cryptography.X509Certificates;
using System.Xml;

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
		
}
