using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
     {
        static double Operand(string prigl)
        {
            double number;
            double operand;
            while (true)
            {
                Console.WriteLine(prigl);
                string input = Console.ReadLine();
                if (double.TryParse(input, out number))
                { operand = number;
                  return operand;
                }
                else
                { Console.WriteLine("Неправильно введен операнд!");
                }
            }
        }
        static void PrintRezult(double firstOperand, string znak, double secondOperand, double rezult)
        {
            Console.WriteLine($"Результат операции {firstOperand}{znak}{secondOperand} = {rezult}");
         }
        static void Vychisl(string znak)
        {
            double rezult;
            double firstOperand;
            double secondOperand;
            switch (znak)
            {
                case "-":
                    firstOperand = Operand("Введите первый операнд");
                    secondOperand = Operand("Введите второй операнд");
                    rezult = firstOperand - secondOperand;
                    PrintRezult(firstOperand, znak, secondOperand, rezult);
                    break;
                case "+":
                    firstOperand = Operand("Введите первый операнд");
                    secondOperand = Operand("Введите второй операнд");
                    rezult = firstOperand + secondOperand;
                    PrintRezult(firstOperand, znak, secondOperand, rezult);
                    break;
                case "*":
                    firstOperand = Operand("Введите первый операнд");
                    secondOperand = Operand("Введите второй операнд");
                    rezult = firstOperand * secondOperand;
                    PrintRezult(firstOperand, znak, secondOperand, rezult);
                    break;
                case "/":
                    firstOperand = Operand("Введите первый операнд");
                    secondOperand = Operand("Введите второй операнд");
                    if (secondOperand == 0)
                    {
                        Console.WriteLine("На ноль делить нельзя!");
                        break;
                    }
                    rezult = firstOperand / secondOperand;
                    PrintRezult(firstOperand, znak, secondOperand, rezult);
                    break;
                default:
                    Console.WriteLine("Неправильно выбрана операция! Сложение - введите \"+\"  Вычитание - введите \"-\"  Умножение - введите \"*\"  Деление - введите \"/\"");
                    znak = Console.ReadLine();
                    Vychisl(znak);
                    break;
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите операцию: Сложение - введите \"+\"  Вычитание - введите \"-\"  Умножение - введите \"*\"  Деление - введите \"/\"");
                string znak = Console.ReadLine();
                Vychisl(znak);
                Console.WriteLine("Для выхода из программы введите \"выход\". Для проведения следующего вычисления введите любой другой символ");
                string e = Console.ReadLine();
                if (e == "выход")
                {
                    Environment.Exit(0);
                }
            }
        }

    }
}
