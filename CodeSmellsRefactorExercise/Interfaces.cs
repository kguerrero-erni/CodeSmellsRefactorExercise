namespace CodeSmellsRefactorExercise
{
    public interface ICalculator
    {
        public void RunCalculation(IList<double> numList);
    }

    public interface IOperations
    {
        public double Average(IList<double> numList, double sum);
        public double Sum(IList<double> numList);
    }

    public interface IInputDataConverter
    {

        public IList<double> StringToDoubleList(string inputNumString);
    }
}
