// Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] array = new int[5];

for (int i = 0; i < array.Length; i++){
    array[i] = new Random().Next(-999, 1000);
}

Console.WriteLine('[' + string.Join(", ", array) + ']');

Console.Write( "Input number: ");
int fnd = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Is {fnd} part of this array?");
bool check = false;
for (int i = 0; i < array.Length; i++){
    if (array[i] == fnd){
        check = true;
        Console.Write("yes");
        break; 
    }
}

if (check == false){
    Console.WriteLine("no");
}