using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)  //поиск самого длинного слова в предложении
        {
            {
                Console.WriteLine("Введите предложение, без знаков припинания:");
                string startString = Console.ReadLine();
                
                string[] stringArray = startString.Split();

                int maxLenghts = 0;
                string result = "";

                foreach (string asd in stringArray)
                {
                    if (maxLenghts < asd.Length)
                    {
                        maxLenghts = asd.Length;
                        result = asd;
                    }

                }
                
                Console.WriteLine("{0} - самое длинное слово в вашем предложении.", result);
                Console.ReadKey();
            }

        }
    }
}
