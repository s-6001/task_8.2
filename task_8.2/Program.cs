using System;
using System.IO;

namespace task_8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "d:/new.txt"; //задаем путь к файлу
            int lines = 10; //задаем количество строк
            if (!File.Exists(path)) //Если файл не существует, то создаем его
            {
                File.Create(path);
            }
            Random rnd = new Random();  //Создаем экземпляр класса для генерации чисел
            StreamWriter sw = new StreamWriter(path, false); //создаем экземпляр класса sw
            for (int i = 0; i < lines; i++) //записываем в файл случайные числа
            {
                sw.WriteLine(rnd.Next(0, 10));//от 0 до 10
            }
            sw.Close(); //закрываем файл после записи
            StreamReader sr = new StreamReader(path);   //создаем экземпляр класса sr
            Console.WriteLine(sr.ReadToEnd()); //выводим содержимое на консоль
            sr.Close(); //закрываем файл после чтения
            StreamReader sr1 = new StreamReader(path);  //создаем экземпляр класса sr1
            int sum = 0;    //сумма чисел
            for (int i = 0; i < lines; i++) //суммируем числа
            {
                sum = sum + Convert.ToInt32(sr1.ReadLine());
            }
            sr.Close(); //закрываем файл после чтения
            Console.WriteLine("Сумма этих чисел равна {0}.",sum); //выводим сумму на консоль
            Console.ReadKey();
        }
    }
}
