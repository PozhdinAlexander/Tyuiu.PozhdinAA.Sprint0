using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PozhdinAA.Sprint0.Task6.V0.Lib;
namespace Tyuiu.PozhdinAA.Sprint0.Task6.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Сумма элементов массива = " + DataService.AdditionArray(numsArray));
            Console.WriteLine("Разность элементов массива = " + DataService.SubtractionArray(numsArray));
            Console.WriteLine("Произведение элементов массива = " + DataService.MultiplicationArray(numsArray));
            Console.ReadKey();
        }
    }
}
