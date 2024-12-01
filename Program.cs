using System.Diagnostics;

do {
double num1 = 0;
double num2 = 0;
double result = 0;

Console.WriteLine("-------------------");
Console.WriteLine("Calculator Program");
Console.WriteLine("-------------------");

Console.Write("Enter Number 1: ");
num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter Number 2: ");
num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter an option: ");
Console.WriteLine("\t+ : Add");
Console.WriteLine("\t- : Subtract");
Console.WriteLine("\t* : Multiply");
Console.WriteLine("\t/ : Divide");
Console.WriteLine("Enter an option");

switch (Console.ReadLine()) 
{
    case "+": result = num1 + num2;
        Console.WriteLine($"Your result: {num1} + {num2} = " + result);
            break; 
    case "-": 
        result = num1 - num2;
        Console.WriteLine($"Your result: {num1} - {num2} = " + result);
            break; 
    case "*": 
        result = num1 * num2; 
        Console.WriteLine($"Your result: {num1} * {num2} = " + result);
            break; 
    case "/": 
        result = num1 / num2; 
        Console.WriteLine($"Your result: {num1} / {num2} = " + result);
            break; 
    default: Console.WriteLine("Not valid"); break; 
}

    Console.WriteLine("Would you like to continue? (Y/N)");
} while (Console.ReadLine().ToUpper() == "Y");

Console.WriteLine("Bye!");
