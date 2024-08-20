namespace CodeSmellsRefactorExercise
{
    public class InputDataConverter : IInputDataConverter
    {
        public IList<double> StringToDoubleList(string inputNumString)
        {
            IList<double> numList = new List<double>();

            // can be its own func 2
            IList<string> stringNumList = inputNumString.Split(' ');

            foreach (string num in stringNumList)
            {
                numList.Add(double.Parse(num));
            }

            return numList;
        }
    }
}
