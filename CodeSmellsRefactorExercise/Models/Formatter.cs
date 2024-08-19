using CodeSmellsRefactorExercise.Interfaces;

namespace CodeSmellsRefactorExercise.Models
{
    public class Formatter : IFormatter
    {
        public void NumberSplitter(string input, List<int> numbers)
        {
            var numberList = input.Split(' ');
            foreach (var number in numberList)
            {
                numbers.Add(int.Parse(number));
            }
        }
    }
}