//3.	За даними, що введені з консолі, визначити значення виразу, 
//використовуючи математичні функції, і вивести результат на консоль.
 
//4.	Обчислити значення функції в точці х, значення якої ввести з консолі, 
//Якщо введено не число, вивести повідомлення «Ввести число».
 
//5.	Написати функцію, яка в залежності від порядкового номера місяця(1,2,...12) 
//виводить на екран його назву(січень,...грудень).
//6.	Дано натуральне число n.Обчислити добуток перших n членів ряду.

using System;

namespace lab1
{
    class Program
    {
        /// <summary>
        ///  головна функція = диспетчер програми
        /// </summary>
        /// <param name="args">рядок для передачи значень у програму ззовні</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(); //пропустити рядок
            Menu();
        }
        /// <summary>
        ///  зображення меню команд програми
        /// </summary>
        static void Menu()
        {
            char command;
            char key;
            do
            {
                Console.WriteLine("Menu of command");
                Console.WriteLine("1 function1");
                Console.WriteLine("2 function2");
                Console.WriteLine("3 function3");
                Console.WriteLine("4 function4");
                Console.WriteLine("5 function5");
                Console.WriteLine("6 function6");
                Console.WriteLine();
                Console.WriteLine("select of command, press number of key");
                command =(char) Console.Read();
                Console.ReadLine();
                switch (command)
                {
                    case '1': Task1(); break;
                    case '2': Task2(); break;
                    case '3': Task3(); break;
                    case '4': Task4(); break;
                    case '5': Task5(); break;
                    case '6': Task6(); break;
                    default: Console.WriteLine("wrong command"); break;
                }
                Console.WriteLine("Continue y/n");
                key = (char)Console.Read();
                Console.ReadLine();
            } while (key!='n');
        } //end of Menu()
        /// <summary>
        /// Вивести на консоль власні анкетні дані
        /// </summary>
        static void Task1()
        {
            string name, e_mail;
            int gr;
            Console.WriteLine("what is your name?");
            name = Console.ReadLine();
            Console.WriteLine("what is your group? - enter integer");
            gr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("name="+name+ " group= " + gr);

        }
        /// <summary>
        /// Обчислення значення поліному 
        /// </summary>
        static void Task2()
        {
            int x;
            Console.WriteLine("enter int x");
            x=Convert.ToInt32(Console.ReadLine());
            double a=1.2, b=3.4, c=-2.51, d=2.0;
            //p = a * x ^ 5 - 1 / b * x ^ 4 + c * x + sind;
            double p = a * Math.Pow((double)x, (double)5) - 1 / b * Math.Pow((double)x, (double)4) + c * x + Math.Sin(d);
            Console.WriteLine("polinom="+p);
        }
        static void Task3()
        {
            double x, a, b;
            Console.WriteLine("enter double a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter double b");
            b = Convert.ToDouble(Console.ReadLine());
            if (a > b)
            {
                x = (Math.Sqrt(a - b) / a) + Math.Abs(Math.Sin(a) / Math.Cos(b));
                Console.WriteLine("x=(Math.Sqrt(a - b) / a) + Math.Abs(Math.Sin(a) / Math.Cos(b))=" + x);
            }
            else
                Console.WriteLine(" корiнь з вiд'ємного числа");
        }
        static void Task4()
        {
            int x,f;
            Console.WriteLine("enter int x");
            x = Convert.ToInt32(Console.ReadLine());
            if (x < 0) f = x - 5;
            else if (x == 0) f = 0;
                 else f = x * x + 4;
            Console.WriteLine("f("+x+")="+f);
        }
        static void Task5()
        {
            Console.WriteLine("ввести рейтинг щастя 1..5 i знайти щасливу країну");
            int select= Convert.ToInt32(Console.ReadLine());
            switch (select)
            {
                case 1: Console.WriteLine("Norvey"); break;
                case 2: Console.WriteLine("Danish"); break;
                case 3: Console.WriteLine("Finlandia"); break;
                case 4: Console.WriteLine("Nova Zeland"); break;
                case 5: Console.WriteLine("Sweden"); break;
                default: Console.WriteLine("wrong command"); break;
            }
        }
        static void Task6()
        {
        }

    }
}
