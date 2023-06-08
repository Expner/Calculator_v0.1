Console.WriteLine("Введите первое число:");
CalculatorData.NumberOne = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите знак:");
CalculatorData.Symbol = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Введите второе число:");
CalculatorData.NumberTwo = Convert.ToInt32(Console.ReadLine());


CalculatorNotification.Evaluate();