var calculator = new Calculator();
var calculatorConsole = new CalculatorConsole();

decimal num1 = calculatorConsole.SetNumber1();
decimal num2 = calculatorConsole.SetNumber2();
calculatorConsole.VievEnum();
operations now = calculatorConsole.SetOperations();

Console.WriteLine(calculator.Evaluate(num1, num2, now));



