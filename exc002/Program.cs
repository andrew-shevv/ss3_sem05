﻿// Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] array = new int[5];

for (int i = 0; i < array.Length; i++){
    array[i] = new Random().Next(-9, 10);
}

Console.Write('[' + string.Join(", ", array) + ']' + " ==> ");

for (int i = 0; i < array.Length; i++){
    array[i] = -array[i];
}

Console.Write('[' + string.Join(", ", array) + ']');