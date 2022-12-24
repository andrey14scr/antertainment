namespace Antertainment.BL.Exceptions;

public sealed class AntertainmentException : Exception
{
    public ErrorCodes ErrorCode { get; set; }

    public AntertainmentException() { }

    public AntertainmentException(ErrorCodes errorCode)
    {
        ErrorCode = errorCode;
    }
}