using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.DiagneB.Sprint0.Task7.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #0 | Выполнил: Диагне Б. | ИБКСБ-26-1";
            // Длина строки 75 символов
            Console.WriteLine("*****************************************");
            Console.WriteLine("* Спринт #0                              *");
            Console.WriteLine("* Тема: Создания итогового решения по спринту                  *");

            //Место решения задания 
            int[] arraysNums1 = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Значение элементов массива  N°1");
            for (int i = 0; i < arraysNums1.Length; i++)
            {
                Console.Write(arraysNums1[i] + ", ");
            }
            Console.WriteLine();

            int[] arraysNums2 = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Значение элементов массива  N°2");
            for (int i = 0; i < arraysNums2.Length; i++)
            {
                Console.Write(arraysNums1[i] + ", ");
            }
            Console.WriteLine();
        }
    }
}
