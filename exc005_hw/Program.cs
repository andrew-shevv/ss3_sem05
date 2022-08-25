// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int[5];
Random rand = new Random();

int count = 0;
for (int i = 0; i < array.Length; i++){
    array[i] = rand.Next(100, 1000);
    if (array[i] % 2 == 0){
        count++;
    }
}

Console.Write('[' + string.Join(", ", array) + ']' + " ==> ");
Console.Write($"{count} even numbers in the array");