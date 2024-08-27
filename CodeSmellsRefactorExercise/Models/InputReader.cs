using System.Text.RegularExpressions;
using CodeSmellsRefactorExercise.Interfaces;

namespace CodeSmellsRefactorExercise.Models
{
    public class InputReader : IInputReader
    {
        public string NumbersReader()
        {
            Console.WriteLine("Enter numbers separated by spaces:");
            var input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                throw new FormatException("No input provided.");
            }

            // ^[0-9 ]+$ - regex pattern for number and white spaces only
            if (!Regex.IsMatch(input, "^[0-9 ]+$"))
            {
                throw new FormatException("This calculator only accepts numbers and spaces.");
            }

            return input;
        }
    }
}