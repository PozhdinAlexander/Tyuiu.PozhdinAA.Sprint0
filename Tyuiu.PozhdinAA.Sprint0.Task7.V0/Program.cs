using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PozhdinAA.Sprint0.Task7.V0.Lib;

namespace Tyuiu.PozhdinAA.Sprint0.Task7.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #0 | Выполнил Пождин А. А. | АСОиУб-23-1";
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* Спринт #0                                                                                       *");
            Console.WriteLine("* Тема: Создания итогового решения по спринту                                                     *");
            Console.WriteLine("* Задание #7                                                                                      *");
            Console.WriteLine("* Вариант #0                                                                                      *");
            Console.WriteLine("* Выполнил: Пождин Александр Андреевич | АСОиУб-23-1                                           *");
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                        *");
            Console.WriteLine("* Написать консольную программу на C#, которая суммирует значения двух                            *");
            Console.WriteLine("* одинаковых массивов по длине.                                                                   *");
            Console.WriteLine("*                                                                                                 *");
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                *");
            Console.WriteLine("***************************************************************************************************");

            int[] arrayNums1 = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Значение элементов массива №1");
            for (int i = 0; i < arrayNums1.Length; i++)
            {
                Console.WriteLine(arrayNums1[i] + ", ");
            }

            Console.WriteLine();

            int[] arrayNums2 = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Значение элементов массива №2");
            for (int i = 0; i < arrayNums2.Length; i++)
            {
                Console.WriteLine(arrayNums2[i] + ", ");
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                      *");
            Console.WriteLine("***************************************************************************************************");
            if (arrayNums1.Length == arrayNums2.Length)
            {
                int[] resultArray = DataService.AdditionArrays(arrayNums1, arrayNums2);

                Console.WriteLine("Сумма элементов массива ровна: ");
                for (int i = 0; i < resultArray.Length; i++)
                {
                    Console.WriteLine(resultArray[i] + ", ");
                }
            }
            else
            {
                Console.WriteLine("Ошибка! Исходные массивы имеют разное количество элементов");
            }
            Console.ReadKey();
        }
    }
}
