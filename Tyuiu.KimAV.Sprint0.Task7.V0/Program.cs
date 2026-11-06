using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KimAV.Sprint0.Task7.V0.Lib;
namespace Tyuiu.KimAV.Sprint0.Task7.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт №0 | Выполнил: Ким А.В. | ИИПБ-25-1";
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* Спринт # 0                                                                                             *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                                                            *");
            Console.WriteLine("* Задание 7                                                                                              *");
            Console.WriteLine("* Выполнил: Ким Артём Владимирович | ИИПБ-25-1                                                           *");
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                               *");
            Console.WriteLine("* Написать консольную команду С#,которая суммирует значение двх одинаковых массива по длинне             *");
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                       *");
            Console.WriteLine("**********************************************************************************************************");
            
            int[] arrayNums1 = new int[] { 1, 2, 3, 4, 5,};

            Console.WriteLine("Значаение элеемнтов массива №1");
            for (int i = 0; i < arrayNums1.Length; i++)
            {
                Console.Write(arrayNums1[i] + ", ");
            }

            Console.WriteLine();
            
            int[] arrayNums2 = new int[] { 1, 2, 3, 4, 5,};
            Console.WriteLine("Значаение элеемнтов массива №2");
            for (int i = 0; i < arrayNums2.Length; i++)
            {
                Console.Write(arrayNums2[i] + ", ");
            }

            Console.WriteLine();
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                             *");
            Console.WriteLine("**********************************************************************************************************");
            if (arrayNums1.Length == arrayNums2.Length)
            {
                int[] resultArray = DataService.AddictionArrays(arrayNums1, arrayNums2);

                Console.WriteLine("Сумма элементов массивов равна");
                for (int i = 0;i < resultArray.Length;i++)
                {
                    Console.Write(resultArray[i] + ", ");
                }
            }
            else
            {
                Console.WriteLine("Ошибка! Исходные массивы имеют разные значения");
            }
            Console.ReadKey();
        }
    }
}
