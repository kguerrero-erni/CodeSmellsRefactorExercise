using System;
using CodeSmellsRefactorExercise.Interface;

namespace CodeSmellsRefactorExercise;

public class Operation : IOperation
{
    public double GetSum(List<int> numbers)
    {
        var sum = 0;
        foreach (var number in numbers)
        {
            sum += number;
        }
        return sum;
    }
    public double GetAverage(double sum, int numberCount)
    {
        double average = sum / numberCount;
        return average;
    }
}
