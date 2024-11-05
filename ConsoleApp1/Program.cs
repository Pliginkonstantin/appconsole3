using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите ваше имя:");
            //string name = Console.ReadLine();
            ////Console.WriteLine($"ваше имя : {name}");
            //Console.WriteLine($"Здравствуй : {name}");
            //Console.Read();

            //task2

            //Console.WriteLine("введите название футбольной комманды :");
            //string name2 = Console.ReadLine();
            //Console.WriteLine($"{name2} -- это чемпион!");
            //Console.Read();

            //Task 3

            //Console.WriteLine("Как вас зовут?");
            //string name3 = Console.ReadLine();
            //Console.WriteLine("какая ваша фамилия?");
            //string surname = Console.ReadLine();
            //Console.Write($"{name3}\t{surname}");
            //Console.Read();

            //task4

            //Console.WriteLine("Здравствуй, я компьютер , а как тебя зовут ?");
            //string name = Console.ReadLine();
            //Console.WriteLine($"Очень приятно ,{name} \n Сколько тебе лет ?" );
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Ого! Целых {age} лет! Ты уже совсем взрослый!");
            //Console.Read();

            //task6

            //Console.WriteLine("Название футбольного клуба");
            //string name = Console.ReadLine();
            //Console.WriteLine($"Количество символов : {name.Length}");
            //Console.Read();

            //Console.Write("Как тебя зовут?");
            //string name = Console.ReadLine();
            //Console.Write($"Привет, {name}! \n Сколько тебе лет?");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Какой у тебя любимый предмет в техникуме?");
            //string Subject = Console.ReadLine();
            //Console.WriteLine("Какая у тебя любимая книга?");
            //string book = Console.ReadLine();
            //Console.Write($"Значит тебя зовут, {name}.\nТебе {age} лет.\nТвой любимый предмет - {Subject}.\n И твоя любимая книга – {book}. ");

            Console.WriteLine("как тебя зовут?");
            String name = Console.ReadLine();
            Console.WriteLine("сколько тебе лет?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"{name} ,ты родился в {2024 - age} году !");
            Console.Read();

        }
    }
}
