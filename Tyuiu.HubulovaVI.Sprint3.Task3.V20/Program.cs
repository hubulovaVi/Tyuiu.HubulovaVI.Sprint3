using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.HubulovaVI.Sprint3.Task3.V20.Lib;

namespace Tyuiu.HubulovaVI.Sprint3.Task3.V20
{
    class Program
    {
        static void Main(string[] args)
        {
             DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Хубулова В. И. | АСОИУб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание: 3                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнила: Хубулова Валерия Игоревна                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach подсчитать количество букв в строке.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value = "gfft ntf f opf";
            char item = 'f';
            Console.WriteLine($"Исходная строка = {value}");
            Console.WriteLine($"Искомый символ = {item}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Количество символов = {ds.GetCharCount(value, item)}");
            Console.ReadKey();
        }
    }
}