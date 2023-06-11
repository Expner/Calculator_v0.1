var calculator = new Calculator();

Console.WriteLine("Введите первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Выберите действие:");
foreach (int i in Enum.GetValues(typeof(operations)))
{
    string oper = Enum.GetName(typeof(operations), i);
    Console.WriteLine($"operations.{oper} = {i}");
}
Console.WriteLine("");
operations now = (operations)Enum.Parse(typeof(operations), Console.ReadLine());

Console.WriteLine("Введите второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine(calculator.Evaluate(num1, num2, now));



