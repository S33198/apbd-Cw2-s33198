namespace ConsoleApp2.Exceptions;

public class RentsLimitException(int UserID)
    : Exception($"UserID {UserID} has to many exceptions");