using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VolovikovMV.Sprint3.Task3.V4.Lib;

namespace Tyuiu.VolovikovMV.Sprint3.Task3.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Воловиков М. В. | АСОиУб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант 4                                                               *");
            Console.WriteLine("* Выполнил: Воловиков Михаил Васильевич | АСОиУб-23-3                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:                                                                *");
            Console.WriteLine("* Используя цикл foreach удалить из строки все буквы j в                  *");
            Console.WriteLine("* строке: plkjjdw cvjkl                                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.WriteLine("***************************************************************************");
            string value = "plkjjdw cvjkl";
            char item = 'j';
            Console.WriteLine("Cтрока: " + value);
            Console.WriteLine("Символ: " + item);
            Console.WriteLine("Результат: " + ds.DeleteCharInString(value, item));
            Console.ReadKey();
        }
    }
}
