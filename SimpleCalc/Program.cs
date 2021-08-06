using System;

namespace SimpleCalc
{
    class Program
    {
        static void Main()
        {
            double num1 = 0;
            double num2 = 0;
            char operand;
            bool errStatus;
            Console.WriteLine("Введите число 1");
            errStatus = double.TryParse(Console.ReadLine(), out num1);
            error(errStatus, "ввода данных числа 1");
            Console.WriteLine("Введите операнд");
            errStatus = char.TryParse(Console.ReadLine(), out operand);
            error(errStatus, "ввода данных операнда");
            Console.WriteLine("Введите число 2");
            errStatus = double.TryParse(Console.ReadLine(), out num2);
            error(errStatus, "ввода данных числа 2");
            Console.WriteLine("Результат: ");
            Console.WriteLine(Operation(num1, num2, operand));
            Console.ReadKey();
        }

        static double Operation(double num1, double num2, char operand)
        {
            double result = 0;
            switch (operand)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
                case ':':
                    result = num1 / num2;
                    break;
                case '^':
                    result = num1;
                    for(int i = 1; i < num2; i++)
                    result *= num1;
                    break;
                case '%':
                    result = (num1 / 100) * num2;
                    break;
                default:
                    error(false, ", несуществующий операнд");
                    break;
            }
            return result;
        }

        static void error(bool status, string name)
        {
            if (status == false)
                Console.WriteLine($"Ошибка {name}"); 
        }
    }
}
