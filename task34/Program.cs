﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] array = new int [4];
Random rand = new Random();
int res = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(100, 1000);
                
        if(array[i] % 2 == 0)
        {
            res += 1;
        }
}
 
    Console.Write(string.Join(" / ", array));
    Console.WriteLine($" Количество четных чисел - {res}");
  
