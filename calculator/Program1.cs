using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
     {
        static void Operand(out operand1, out operand2)
        { 
            double number1;
            double number2;
            double operand1;
            double operand2;
            while (true)
            {
                Console.Write("Введите первый операнд");
                string input1 = Console.ReadLine();
                if (double.TryParse(input1, out number1))
                { operand1 = number1;
                    while (true)
                    {
                        Console.Write("Введите второй операнд");
                        string input2 = Console.ReadLine();
                        if (double.TryParse(input2, out number2))
                        {
                            operand2 = number2;
                            break;
                        }
                        else
                        { Console.Write("Неправильно введен второй операнд!Нажмите <Enter>");
                        }
                    }
                }
                else
                { Console.Write("Неправильно введен второй операнд!Нажмите <Enter>");
                }
            }
        static void Main(string[] args)
        {
        }
    }
}
