using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DiagneB.Sprint0.Task4.V0.Lib;
namespace Tyuiu.DiagneB.Sprint0.Task4.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Пример линейной структуры программы
            //Вызов метода сложения Addition
            Console.WriteLine(DataService.Addition(1, 5));
            //Вызов метода вычитания Soustraction
            Console.WriteLine(DataService.Soustraction(15, 5));
            //Вызов метода умножения Multiplication
            Console.WriteLine(DataService.Multiplication(10, 10));
            //Вызов метода деления Division
            Console.WriteLine(DataService.Division(5, 5));

            Console.ReadKey();
        }
    }
}
