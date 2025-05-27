using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace рпл
{
    internal class Новелла
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в интерактивную новеллу!");
            Console.WriteLine("Вы просыпаетесь в незнакомом месте. Перед вами два пути.");
            Console.WriteLine("1. Пойти в лес.");
            Console.WriteLine("2. Пойти к реке.");
            Console.Write("Выберите действие (1 или 2): ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                ForestPath();
            }
            else if (choice == "2")
            {
                RiverPath();
            }
            else
            {
                Console.WriteLine("Неверный выбор. Игра окончена.");
            }
        }

        static void ForestPath()
        {
            Console.WriteLine("\nВы идете в лес и встречаете странного старика.");
            Console.WriteLine("1. Поговорить со стариком.");
            Console.WriteLine("2. Обойти старика стороной.");
            Console.Write("Выберите действие (1 или 2): ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("\nСтарик дает вам волшебный амулет, который защищает вас от опасностей.");
                Console.WriteLine("Вы продолжаете путь и находите выход из леса. Поздравляем, вы выиграли!");
            }
            else if (choice == "2")
            {
                Console.WriteLine("\nВы обходите старика, но заблудились в лесу и не можете найти выход.");
                Console.WriteLine("Игра окончена.");
            }
            else
            {
                Console.WriteLine("Неверный выбор. Игра окончена.");
            }
        }

        static void RiverPath()
        {
            Console.WriteLine("\nВы подходите к реке и видите лодку.");
            Console.WriteLine("1. Переплыть реку на лодке.");
            Console.WriteLine("2. Идти вдоль берега.");
            Console.Write("Выберите действие (1 или 2): ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("\nЛодка течет по течению, и вы безопасно достигаете другой стороны.");
                Console.WriteLine("Вы нашли дорогу домой. Поздравляем, вы выиграли!");
            }
            else if (choice == "2")
            {
                Console.WriteLine("\nИдя вдоль берега, вы наткнулись на стаю волков.");
                Console.WriteLine("Игра окончена.");
            }
            else
            {
                Console.WriteLine("Неверный выбор. Игра окончена.");
            }
        }
    }
}

