using System;
using CodeSmellsRefactorExercise.Interface;

namespace CodeSmellsRefactorExercise;

public class Parse : IParse
{
    public List<int> ParseToList(string input, List<int> numbers)
    {
        var numList = input.Split(' ');
        foreach (var n in numList)
        {
            numbers.Add(int.Parse(n));
        }
        return numbers;
    }
}
