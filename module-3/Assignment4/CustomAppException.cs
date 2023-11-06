using System;

class CustomAppException : Exception
{
    public int ErrorCode { get; }

    public CustomAppException(int errorCode, string message)
        : base(message)
    {
        ErrorCode = errorCode;
    }
}
