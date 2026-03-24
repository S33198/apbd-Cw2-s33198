namespace ConsoleApp2.Exceptions;

public class RentLimitException(int UserID)
    : Exception($"UserID {UserID} has to many exceptions");