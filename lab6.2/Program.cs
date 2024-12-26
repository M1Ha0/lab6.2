﻿using static ClassLab6_2.ClassLib;
Random random = new Random();
int[,] mas = new int[4, 5];
for (int i = 0; i < mas.GetLength(0); i++)
{
	for (int j = 0; j < mas.GetLength(1); j++)
	{
		mas[i, j] = random.Next(10, 100);
		Console.Write(mas[i, j] + " ");
	}
	Console.WriteLine();
}
Console.WriteLine("Сумма столбцов");
int[] vector = Sum(mas);
for (int i = 0; i < vector.Length; i++)
{
    Console.Write(vector[i] + " ");
}