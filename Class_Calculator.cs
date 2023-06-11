class Calculator
{
    public decimal Evaluate(decimal num1, decimal num2, operations now)
    {
        switch (now)
        {
            case operations.Plus:
                return Addition(num1, num2);

            case operations.Minus:
                return Subtraction(num1, num2);

            case operations.Mult:
                return Multiplication(num1, num2);

            case operations.Div:
                return Division(num1, num2);

            default:
                Console.WriteLine("argumentOutOfRange");
                return 0;
        }
    }
    private decimal Addition(decimal num1, decimal num2)
    {
        return num1 + num2;
    }
    private decimal Subtraction(decimal num1, decimal num2)
    {
        return num1 - num2;
    }
    private decimal Multiplication(decimal num1, decimal num2)
    {
        return num1 * num2;
    }
    private decimal Division(decimal num1, decimal num2)
    {
        return num1 / num2;
    }
}

