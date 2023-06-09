public class CalculatorSwitchOperation
{
    public int Math(int num1, int num2, CalculatorEnumOperation.Operation now )
    {
        switch (now)
        {
            case Operation.Plus: 
                Calculator.Addition(num1,num2);
                break;

            case Operation.Minus:
                Calculator.Subtraction(num1, num2);
                break;

            case Operation.Mult:
                Calculator.Multiplication(num1, num2);
                break;

            case Operation.Div: 
                Calculator.Division(num1, num2);
                break;

            default: return 0;
        }
    }
}
