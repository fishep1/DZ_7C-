
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
double[,] myArray = new double[3, 4]
           {
                {1,4,7,2,},
                {5,9,2,3,},
                {8,4,2,4,}

           };
for (int y = 0; y < myArray.GetLength(0); y++)
{
    for (int x = 0; x < myArray.GetLength(1); x++)
    {
        Console.Write(myArray[y, x] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();

double num = (myArray[0, 0] + myArray[1, 0] + myArray[2, 0]) / 3;
double num1 = (myArray[0, 1] + myArray[1, 1] + myArray[2, 1]) / 3;
double num2 = (myArray[0, 2] + myArray[1, 2] + myArray[2, 2]) / 3;
double num3 = (myArray[0, 3] + myArray[1, 3] + myArray[2, 3]) / 3;

Console.WriteLine($"{(Math.Round(num, 2))}, {Math.Round(num1, 2)}, {Math.Round(num2, 2)}, {Math.Round(num3, 2)} ");