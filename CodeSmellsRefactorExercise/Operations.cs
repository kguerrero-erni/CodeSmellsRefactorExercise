namespace CodeSmellsRefactorExercise
{
    public class Operations : IOperations
    {
        public double Average(IList<double> numList, double sum)
        {
            double average = sum / numList.Count;

            return average;
        }

        public double Sum(IList<double> numList)
        {
            double sum = 0;
            foreach (var number in numList)
            {
                sum += number;
            }
            return sum;

        }
    }
}
