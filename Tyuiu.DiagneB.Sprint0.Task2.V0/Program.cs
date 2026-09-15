using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.DiagneB.Sprint0.Task2.V0.Lib;
namespace Tyuiu.DiagneB.Sprint0.Task2.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вызов класса DataService и метода GetMessage
            // из библиотеки Tyuiu.DiagneB.Sprint0.Task2.V0.Lib
            Console.WriteLine(DataService.GetMessage("Бабакар"));
            Console.ReadKey();
        }
    }
}
