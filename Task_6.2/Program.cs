using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6._2
{
    class Program
    {
        static void Main(string[] args)  //проверка является ли строка палиндромом
        {
            Console.WriteLine("Введите предложение, без знаков припинания:");
            string startString = Console.ReadLine();
            startString = startString.Replace(" ", "");    //убрали пробелы
            startString = startString.ToUpper();           // перевели в верхний регистр

            char[] stringArray = startString.ToCharArray();


            Array.Reverse(stringArray);

            string finalString = new string(stringArray);

            if (finalString == startString)
            {
                Console.WriteLine("Введеное предложение является палиндромом");
            }
            else
            {
                Console.WriteLine("Введеное предложение не является палиндромом");
            }

            Console.ReadKey();
        }
    }
}
