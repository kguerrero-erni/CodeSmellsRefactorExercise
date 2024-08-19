namespace CodeSmellsRefactorExercise.Interfaces;

public interface IInputService
{
    public string GetInput();
    List<double> ParseNumbers(string input);
}