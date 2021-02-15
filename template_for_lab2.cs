/*1.	Згенерувати елементи одновимірного масиву, задавши їх кількість з консолі.
 * Відсортувати згенерований масив за спаданням значень його елементів алгоритмом бульбашкового
 * сортування. Вивести на консоль масив до та після сортування. 
2.	У згенерованому масиві визначити прості числа та вивести їх на консоль.
3.	метод лінійного пошуку. див. методичку
4.	Вивести на консоль значення мінімального та максимального елементів масиву та їх індекси, 
застосувавши метод лінійного пошуку (повнй перебір).
5.	Вивести на консоль значення елемента, заданого з консолі, застосувавши метод 
бінарного пошуку. У разі його відсутності в масиві вивести відповідне повідомлення. 

6.	Згенерувати елементи матриці, задавши її вимірність з консолі.Вивести матрицю на консоль 
у вигляді таблиці.Визначити суму елементів заданого з консолі номеру рядка матриці 
Вивести на консоль номери рядка та стовпчика матриці та обчислені суми.
7.	Вивести на консоль значення мінімального та максимального елементів матриці та їх індекси, 
застосувавши методи класу Math.
8.	Знайти корені нелінійного рівняння 6x43x3+8x225=0, застосувавши метод половинного ділення (метод бісекції). Вивести результати на консоль. Здійснити перевірку правильності рішення, підставивши знайдені значення коренів в нелінійне рівняння.
9.	Увести з консолі рядок символів (тип string). Виконати операції редагування рядка, 
здійснивши пошук та заміну підрядка на заданий з консолі підрядок, 
вставку підрядка, видалення заданого підрядка.Вивести на консоль рядок після редагування.
*/
using System;

namespace demolab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab#2, var#1, Student Name, group IPZ1?");
            Menu();
        }
            
        /// <summary>
        /// Menu of tasks by variant
        /// </summary>
        static void Menu()
        {
            const int n = 10; //size of array
            int[] array = new int[n]; //виділення пам'яті під масив =>створення об'єкту array
            

            char command; //команда меню
            char answer;  //відповідь за запитання "продовжити програму"
            do
            {
                Console.WriteLine("Menu of command");
                Console.WriteLine("1 Sort array");
                Console.WriteLine("2 simple numbers");
                Console.WriteLine("3 Linear finding");
                Console.WriteLine("4 Min max in array");
                Console.WriteLine("5 Binary searching");
                Console.WriteLine("6 Row sum and column sum in matrix");
                Console.WriteLine("7 Min max in matrix");
                Console.WriteLine("8 Not linear equqtion");
                Console.WriteLine("9 string processing");
                Console.WriteLine();
                Console.WriteLine("select of command, press number of key");
                command = (char)Console.Read();
                Console.ReadLine();
                switch (command)
                {
                    case '1': Task1(array); break;
                    case '2': Task2(array); break;
                    case '3': Task3(); break;
                    case '4': Task4(array); break;
                    case '5': Task5(array); break;
                    case '6': Task6(); break;
                    case '7': Task7(); break;
                    case '8': Task8(); break;
                    case '9': Task9(); break;
                    default: Console.WriteLine("wrong command"); break;
                }
                Console.WriteLine("Continue y/n");
                answer = (char)Console.Read();
                Console.ReadLine();
            } while (answer != 'n');
        } //end of Menu()
        /// <summary>
        /// генерація масиву
        /// </summary>
        /// <param name="mas"></param>
        static void arraygenerate(int[] mas)
        {
            // Random - клас для генерації випадкових чисел
            Random aRand = new Random();
            // заповнення масиву
            for (int i = 0; i < mas.Length; i++)
                mas[i] = aRand.Next(50);
        }
        /// <summary>
        /// друк масиву
        /// </summary>
        /// <param name="mas"></param>
        static void arrayprint(int[] mas)
        {
            Console.WriteLine("Друк масиву");
            for (int i = 0; i < mas.Length; i++)
                Console.Write( mas[i]+"  ");
            Console.WriteLine();
        }
        /// <summary>
        /// бульбашкове сортування масиву
        /// </summary>
        /// <param name="mas"></param>
        static void arraysort(int[] mas)
        {
            for (int i=0;i<mas.Length;i++)
                for (int j=i+1;j<mas.Length;j++)
                {
                    if (mas[i]<mas[j])
                    { int tmp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = tmp;
                    }
                }
        }
        /// <summary>
        /// завдання1
        /// </summary>
        /// <param name="mas"></param>
        static void Task1(int[] mas)
        {
            arraygenerate(mas);
            Console.WriteLine("array before sort");
            arrayprint(mas);
            arraysort(mas);
            Console.WriteLine("array after sort");
            arrayprint(mas);
        }

        /// <summary>
        /// прості числа в масиві. !!!Не використовується решето Ератосфена
        /// </summary>
        /// <param name="mas"> масив цілих чисел</param>
        static void Task2(int[] mas)
        {
            Console.WriteLine("simple numbers: " );
            for (int i = 0; i < mas.Length; i++)
            {
                int k = 2;
                while (k <= (int)Math.Sqrt(mas[i]))
                {
                    if (mas[i] % k == 0)        //якщо k ділить mas[i], 
                        break;                  //перервати цикл - число складене 
                    k++;                        //вибрати наступний дільник      
                }
                if (k == (int)Math.Sqrt(mas[i]) + 1) //якщо усі дільники перевірено, 
                    Console.Write(mas[i]+" ");            //число є простим   
            }
            Console.WriteLine();
        }
        /// <summary>
        /// завдання 3
        /// </summary>
        static void Task3()
        {
        }
        /// <summary>
        /// min max elements and its indexes
        /// </summary>
        /// <param name="mas">масив, в якому шукаються min, max</param>
        static void Task4(int[] mas) 
        {
            int max = mas[0]; int indmax = 0;            // максимальний елемент
            int min = mas[0]; int indmin = 0;
            for (int i = 1; i < mas.Length; ++i)
            {
                if (mas[i] > max)
                {
                    max = mas[i]; indmax = i;
                }
                if (mas[i] < min)
                {
                    min = mas[i]; indmin = i;
                }
            }
            Console.WriteLine("Максимальний елемент = " + max+" indexmax="+ indmax);
            Console.WriteLine("Мінімальний елемент = " + min + " indexmin=" + indmin);
        }
        
        /// <summary>
        /// binary search
        /// </summary>
        /// <param name="mas">масив, в якому шукається значення</param>
        static void Task5( int[] mas )
        {
            int key;  //шуканий елемент
            int  begin, end, middle; //індекси початкового, кінцевого та серединного елементів
            bool flag = false; //ознака успішного пошуку 
            
            Console.WriteLine("ввести шуканий елемент");
            key = int.Parse(Console.ReadLine());
           
            begin = 0; end = mas.Length; //ліва і права границі масиву
                //пошук у відсортованому за спаданням масиву
            while (begin < end)
            {
                middle = begin + (end - begin) / 2;// середина масиву
                if (key > mas[middle]) //якщо шуканий елемент > елемента в середині шуканого діапазону 
                        end = middle;  //міняємо праву границю
                else if (key < mas[middle]) 
                        begin = middle + 1;  //міняємо ліву границю
                else { flag = true; break; } //елемент знайдено
            }
            if (flag == true)
            {
                middle = begin + (end - begin) / 2;
                Console.WriteLine("Елемент знайдено на позицiї="+ middle);
            }
            else Console.WriteLine("Елемент не знайдено");
            Console.ReadKey();
        }
        /// <summary>
        /// генерація матриці
        /// </summary>
        static  void matrgenerate(int str, int stolb, int[,] matr)
        {
            //int row;
            //int col;
            //Console.Write("Enter number of rows");
            //row = int.Parse(Console.ReadLine());
            //Console.Write("Enter number of colunms");
            //col = int.Parse(Console.ReadLine());
            //int[,] matr = new int[str, stolb];
            Random rand = new Random();
            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < stolb; j++)
                {
                    //Console.Write("enter value: ");
                    //matr[i, j] = int.Parse(Console.ReadLine()); введення елемента матриці
                    matr[i, j] = rand.Next(20); //генерація елемента матриці
                }
            }
           // return matr;
        }
        /// <summary>
        /// ///////////////
        /// </summary>
        /// <param name="str"></param>
        /// <param name="stolb"></param>
        /// <param name="matr"></param>
        static void matrprint(int str, int stolb, int[,] matr)
        {
            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < stolb; j++)
                {
                    Console.Write(matr[i, j]+"\t");
                }
                Console.WriteLine();
            }
        }
        static int sumrow(int str, int stolb, int[,] matr, int rowind)
        {
            int sum = 0;
            
            for (int j = 0; j < stolb; j++)
            {
                sum += matr[rowind, j];
            }
            return sum;

        }
        /// <summary>
        /// робота з матрицею
        /// </summary>
        static void Task6()
        {
            Console.Write("Enter number of rows: ");
            int  row = int.Parse(Console.ReadLine()); //ведення кількості рядків матриці
            Console.Write("Enter number of colunms: "); 
            int  col = int.Parse(Console.ReadLine()); //введення кількості стовпчиків матриці
            int[,] matr = new int[row, col]; //створення об'єкта матриці
            matrgenerate(row, col, matr);  //генерація матриці
            matrprint(row, col,matr);   //друк матриці
            Console.Write("Enter number of row for sum: ");
            int r = int.Parse(Console.ReadLine());  //введення номера рядка для розрхунку його суми
            int summa= sumrow( row, col, matr, r);  //розрахунок суми рядка r
            Console.WriteLine("sum of row "+r+" = "+summa);
        }
        /// <summary>
        /// ////////
        /// </summary>
        static void Task7()
        {
        }
        /// <summary>
        /// ////////
        /// </summary>
        static void Task8()
        {
        }
        /// <summary>
        /// ////////
        /// </summary>
        static void Task9()
        {
        }
    }
}

