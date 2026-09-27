using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.DiagneB.Sprint0.Task5.V0.Lib
{
    public class DataService
    {
        //Пример линейной структуры 
        public static int Addition(int a, int b)
        {
            return a + b;
        }
        public static int Soustraction(int a, int b)
        {
            return a - b;
        }
        public static int Multiplication(int a, int b)
        {
            return a * b;
        }
        public static int Division(int a, int b)
        {
            if (b == 0)
            {
                //Пример создан в целях демонстрация ветвления
                //В реальных проектах нужно использовать exception
                Console.WriteLine("переменная b = {0} на ноль делить нельзя", b);
                return -1;
            }
            else
            {
                return a / b;
            }
        }
    }
}
