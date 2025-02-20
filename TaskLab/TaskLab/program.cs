using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskLab
{
    class program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Выберите класс для запуска (1, 2 или 4):");
            string input = Console.ReadLine();

            if (input == "1")
            {
                Task1.Main1();
            }
            else if (input == "2")
            {
                Task2.Main2();
            }
            
            else if (input == "4")
            {
                Task4.Main4();
            }
            else
            {
                Console.WriteLine("Неверный ввод.");
            }



        }
    }
}
