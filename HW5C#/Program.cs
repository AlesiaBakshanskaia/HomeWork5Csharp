// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int[] Array34 = GetArray(10, 100, 999);
Console.WriteLine(String.Join(" ", Array34));
Console.WriteLine($"Количество четных числе в массиве {CountEven(Array34)}");


//Метод подсчета четных чисел в массиве
int CountEven (int[] array){
    int count = 0;
    foreach (int element in array){
        if (element%2 == 0){
            count += 1;
        }
    }
    return count;
}

















//Метод задания массива
int[] GetArray (int size, int min, int max){
    int[] res = new int[size];
    for (int i = 0; i < size; i++){
        res[i] = new Random().Next(min, max+1);
    }
    return res;
}