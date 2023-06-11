class Calculator
{
    private int Addition(int num1, int num2)
    {
        return num1 + num2;
    }
    private int Subtraction(int num1, int num2)
    {
        return num1 - num2;
    }
    private int Multiplication(int num1, int num2)
    {
        return num1 * num2;
    }
    private int Division(int num1, int num2)
    {
        return num1 / num2;
    }




    public int Evaluate(int num1, int num2, operations now)
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

            default: return 0;
        }
    }
}

