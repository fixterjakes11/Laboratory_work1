using System;

namespace Laboratory_work1
{
    class Program 
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Нажмите Enter для продолжения...");
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                    Text();
                else
                    break;
            }
        }

        public static void Text()
        {
            try
            {
                Console.WriteLine("Введите число A: ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите число B: ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Результат: ряд чисел от A = {0} до B = {1}:", a, b);
                Logic.Count(a, b);
                
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка, попробуйте ввести число\n");
            }
        }
    }

}
