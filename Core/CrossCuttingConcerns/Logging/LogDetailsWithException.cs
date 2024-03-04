namespace Core.CrossCuttingConcerns.Logging;
public class LogDetailsWithException : LogDetail
{
    public string ExceptionMessage { get; set; }
}