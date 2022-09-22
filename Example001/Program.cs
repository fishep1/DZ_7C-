/*Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.*/
using System;
class Programm
{
    static void Main(string[] args)
    {
        double[,] myArray = new double[3, 4];
        Random random = new Random();

        for (int y = 0; y < myArray.GetLength(0); y++)
        {
            for (int x = 0; x < myArray.GetLength(1); x++)
            {
                myArray[y,x] =random.Next(10) + Convert.ToDouble(random.Next(-1,10))/10;
            }
        }
        for (int y = 0; y < myArray.GetLength(0); y++)
        {
            for (int x = 0; x < myArray.GetLength(1); x++)
            {
                Console.Write(string.Format("{0:F1}", myArray[y, x] + "\t"));
            }
            Console.WriteLine();
        }
    }
}