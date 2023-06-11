class CalculatorConsole
{
    public decimal SetNumber1()
    {
        Console.WriteLine("Введите первое число:");
        return Convert.ToDecimal(Console.ReadLine());
    }

    public  decimal SetNumber2()
    {
        Console.WriteLine("Введите второе число:");
        return Convert.ToDecimal(Console.ReadLine());
    }

    public void VievEnum()
    {
        Console.WriteLine("Выберите действие:");
        foreach (int i in Enum.GetValues(typeof(operations)))
        {
            string oper = Enum.GetName(typeof(operations), i);
            Console.WriteLine($"operations.{oper} = {i}");
        }
    }

    public operations SetOperations()
    {
        return (operations)Enum.Parse(typeof(operations), Console.ReadLine());
    }
}