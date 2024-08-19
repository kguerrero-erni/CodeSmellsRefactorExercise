namespace CodeSmellsRefactorExercise.Interfaces;

public interface ICalculator
{
    public double Sum(List<double> numbers);

    public double Average(double sum, int count);
}