using System;
using System.Threading;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string text, untext;
            Char again = 'y';
            while (again == 'y')
            {
                Console.WriteLine("1: зашифровать");
                Console.WriteLine("2: расшифровать");

                ConsoleKey key = GetButton();
                Console.Clear();
                if (key == ConsoleKey.D1)
                {
                    Console.WriteLine("впишите то, что вы хотите зашифровать:");

                    text = Console.ReadLine();

                    text = text.Replace("а", "*");
                    text = text.Replace("б", "%");
                    text = text.Replace("в", "2");
                    text = text.Replace("г", "_");
                    text = text.Replace("д", "=");
                    text = text.Replace("е", "/");
                    text = text.Replace("ж", "?");
                    text = text.Replace("з", "~");
                    text = text.Replace("и", "v");
                    text = text.Replace("й", "-");
                    text = text.Replace("к", ")");
                    text = text.Replace("л", "(");
                    text = text.Replace("м", "&");
                    text = text.Replace("н", "!");
                    text = text.Replace("о", "+");
                    text = text.Replace("п", "|");
                    text = text.Replace("р", "^");
                    text = text.Replace("с", "$");
                    text = text.Replace("т", "`");
                    text = text.Replace("у", "]");
                    text = text.Replace("ф", "[");
                    text = text.Replace("х", "}");
                    text = text.Replace("ц", "{");
                    text = text.Replace("ч", "z");
                    text = text.Replace("ш", "t");
                    text = text.Replace("щ", "m");
                    text = text.Replace("ъ", "l");
                    text = text.Replace("ы", "g");
                    text = text.Replace("ь", "f");
                    text = text.Replace("э", "k");
                    text = text.Replace("ю", "d");
                    text = text.Replace("я", "x");
                    text = text.Replace(" ", "p");
                    text = text.Replace(".", "q");
                    text = text.Replace(",", "u");
                    Console.WriteLine(text);
                    Thread.Sleep(5000);
                    Console.Clear();
                }
                else if (key == ConsoleKey.D2)
                {
                    Console.WriteLine("впишите то, что вы хотите расашифровать:");
                                 
                    untext = Console.ReadLine();

  
                    untext = untext.Replace("*", "а");
                    untext = untext.Replace("%", "б");
                    untext = untext.Replace("2", "в");
                    untext = untext.Replace("_", "г");
                    untext = untext.Replace("=", "д");
                    untext = untext.Replace("/", "е");
                    untext = untext.Replace("?", "ж");
                    untext = untext.Replace("~", "з");
                    untext = untext.Replace("v", "и");
                    untext = untext.Replace("-", "й");
                    untext = untext.Replace(")", "к");
                    untext = untext.Replace("(", "л");
                    untext = untext.Replace("&", "м");
                    untext = untext.Replace("!", "н");
                    untext = untext.Replace("+", "о");
                    untext = untext.Replace("|", "п");
                    untext = untext.Replace("^", "р");
                    untext = untext.Replace("$", "с");
                    untext = untext.Replace("`", "т");
                    untext = untext.Replace("]", "у");
                    untext = untext.Replace("[", "ф");
                    untext = untext.Replace("}", "х");
                    untext = untext.Replace("{", "ц");
                    untext = untext.Replace("z", "ч");
                    untext = untext.Replace("t", "ш");
                    untext = untext.Replace("m", "щ");
                    untext = untext.Replace("l", "ъ");
                    untext = untext.Replace("g", "ы");
                    untext = untext.Replace("f", "ь");
                    untext = untext.Replace("k", "э");
                    untext = untext.Replace("d", "ю");
                    untext = untext.Replace("x", "я");
                    untext = untext.Replace("p", " ");
                    untext = untext.Replace(".", "q");
                    untext = untext.Replace(",", "u");
                    Console.WriteLine(untext);
                    Thread.Sleep(5000);
                    Console.Clear();

                }
 
            }
            Console.WriteLine("вы хотите продолжить работу?");
            Thread.Sleep(3000);
            Console.Clear();
            again = Convert.ToChar(Console.ReadLine());
            Console.ReadKey();
        }
     public static ConsoleKey GetButton()
        {
            var but = Console.ReadKey(true).Key;

            return but;
        }
    }
}