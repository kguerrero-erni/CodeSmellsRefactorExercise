using System;

namespace CodeSmellsRefactorExercise.Interface;

public interface IParse
{
    public List<int> ParseToList(string input, List<int> numbers);
}
