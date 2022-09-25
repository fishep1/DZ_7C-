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
<<<<<<< HEAD
                myArray[y,x] =random.Next(-10, 10) + Convert.ToDouble(random.Next(1,10))/10;
=======
                myArray[y,x] =random.Next(-10, 10) + Convert.ToDouble(random.Next(1, 10))/10;
>>>>>>> 077fe808509a86d5e6809a6a2ea74bf42c434c82
            }
        }
        for (int y = 0; y < myArray.GetLength(0); y++)
        {
            for (int x = 0; x < myArray.GetLength(1); x++)
            {
<<<<<<< HEAD
                Console.Write(myArray[y, x] + "\t");
=======
                Console.Write(myArray[y, x] + "\t"));
>>>>>>> 077fe808509a86d5e6809a6a2ea74bf42c434c82
            }
            Console.WriteLine();
        }
    }
}
