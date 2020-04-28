using System;

namespace tt
{
    class Program
    {
        static void Main(string[] args)
        {
            int input, s, m, h;

            char again = 'y';
            while(again == 'y')
            { 
                char menu = 'r';
                Console.WriteLine("чтобы посмотреть правила, напишите |r|. чтобы продолжить, напишите |c| (на англиском).");
                menu = Convert.ToChar(Console.ReadLine());
                if (menu == 'r')
                {
                    Console.WriteLine("эта программа переводит количество введенных секунд в формат: часы, минуты, секунды. Например: Если ввести число 5840 - програма должна написать: 1 ч. 37 м. 20 сек.");
                }
                else
                {
                    Console.WriteLine("Введите секунды:");
                    input = Convert.ToInt32(Console.ReadLine());
                    
                    s = input % 60;
                    m = input / 60;
                    h = m / 60;
                    m = m % 60;

                    Console.WriteLine("часы:" + h + ".");
                    Console.WriteLine("минуты:" + m + ".");
                    Console.WriteLine("секунды:" + s + ".");

                    Console.WriteLine("вы хотите продолжить работу? (y/n)");
                    again = Convert.ToChar(Console.ReadLine());
                }
            }


        }
    }
}