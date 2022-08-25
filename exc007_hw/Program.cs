// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[new Random().Next(3, 10)];
Random rand = new Random();

int sumOdd = 0;
for (int i = 0; i < array.Length; i++){
    array[i] = rand.Next(-99, 100);
    if (i % 2 != 0){
        sumOdd += array[i];
    }
}

Console.Write('[' + string.Join(", ", array) + ']' + " ==> ");
Console.Write($"{sumOdd} is the sum of odd position numbers in the array");