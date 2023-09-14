using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW4_C_Sharp_Kh_P
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int SIZE_ARR = 10;
            int[,] randArr = new int[SIZE_ARR, SIZE_ARR];
            Random rand = new Random();
            for(int i = 0; i < SIZE_ARR; i++)
            {
                for(int j = 0 ; j < SIZE_ARR; j++) 
                {
                    randArr[i, j] = rand.Next(0, 500);
                }
            }
            Console.WriteLine("Рандомный массив 10x10: ");
            for (int i = 0; i < SIZE_ARR; i++)
            {
                for (int j = 0; j < SIZE_ARR; j++)
                {
                    Console.Write(randArr[i, j] + " ");
                }
                Console.Write("\n");
            }

            int max = randArr[0,0];
            int min = randArr[0,0];
            for (int i = 0; i < SIZE_ARR; i++)
            {
                for (int j = 0; j < SIZE_ARR; j++)
                {
                    if(min > randArr[i, j])
                        min = randArr[i, j];
                }
            }
            for (int i = 0; i < SIZE_ARR; i++)
            {
                for (int j = 0; j < SIZE_ARR; j++)
                {
                    if(max < randArr[i, j])
                        max = randArr[i, j];
                }
            }
            Console.Write("\n");
            Console.WriteLine($"Максимальное значение в массиве: {max} \nМинимальное значение в массиве: {min}");
            Console.ReadLine();
        }
    }
}
