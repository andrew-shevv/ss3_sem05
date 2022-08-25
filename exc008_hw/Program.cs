// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = new double[new Random().Next(3, 10)];
Random rand = new Random();

for (int i = 0; i < array.Length; i++){
    array[i] = rand.Next(1, 100);
}

Console.Write('[' + string.Join(", ", array) + ']' + " ==> ");

double min = array[0];
double max = array[0];

for (int i = 1; i < array.Length; i++){
    if (array[i] < min){
        min = array[i];
    }
    else if (array[i] > max){
        max = array[i];
    }
}

Console.WriteLine($"{max - min} is the diff between highest and lowest value in the array");