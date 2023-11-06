class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Simulate a scenario where CustomAppException is raised
            int result = Divide(10, 0); // Division by zero
            Console.WriteLine("Result: " + result);
        }
        catch (CustomAppException ex)
        {
            Console.WriteLine($"CustomAppException caught: ErrorCode={ex.ErrorCode}, Message={ex.Message}");
        }
    }

    static int Divide(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            // Throwing CustomAppException with ErrorCode and message
            throw new CustomAppException(1001, "Division by zero is not allowed.");
        }
        return numerator / denominator;
    }
}
