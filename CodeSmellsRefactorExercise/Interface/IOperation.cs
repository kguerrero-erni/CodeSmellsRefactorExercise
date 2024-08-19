using System;

namespace CodeSmellsRefactorExercise.Interface;

public interface IOperation
{
    public double GetSum(List<int> numbers);
    public double GetAverage(double sum, int count);
}
