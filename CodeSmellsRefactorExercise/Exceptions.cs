namespace CodeSmellsRefactorExercise
{
    public class InvalidInputException : Exception {
        public InvalidInputException() { }

        public InvalidInputException(string message) : base(message) { }

        public InvalidInputException(string message, Exception innerException) 
            : base(message, innerException) 
        { }
    }

    public class EmptyInputException : Exception { 
        public EmptyInputException() { }
        public EmptyInputException(string message) : base(message)
        {}
        public EmptyInputException(string message, Exception innerException) 
            : base(message, innerException)
        {}
    }

    public class OutputIsZeroException : Exception { 
        public OutputIsZeroException() { }
        public OutputIsZeroException(string message) : base(message) {}
        public OutputIsZeroException(string message, Exception innerException) 
            : base(message, innerException) { }
    }
}
