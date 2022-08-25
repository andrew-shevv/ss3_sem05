// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] array = new int[new Random().Next(3, 10)];

for (int i = 0; i < array.Length; i++){
    array[i] = new Random().Next(1, 10);
}

int[] arrMult = new int[array.Length / 2 + array.Length % 2];

for (int i = 0; i < arrMult.Length; i++){
    if (array[i] == array[array.Length - i - 1]){
        arrMult[i] = array[i];
    }
    else {
        arrMult[i] = array[i] * array[array.Length - i - 1];
    }
}

Console.Write('[' + string.Join(", ", array) + ']' + " ==> " + '[' + string.Join(", ", arrMult) + ']');