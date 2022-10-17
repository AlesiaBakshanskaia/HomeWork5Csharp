// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*int[] Array34 = GetArray(10, 100, 999);
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
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] Array36 = GetArray(9, -100, 100);
Console.WriteLine(String.Join(" ", Array36));
Console.WriteLine($"Сумма чисел на нечетных позициях в массиве {SumEvenPosition(Array36)}");

//Метод поиска суммы элементов на нечетных позициях массива
int SumEvenPosition (int[] array){
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2){
        sum += array[i];
    }
    return sum;    
    }


//Метод поиска суммы элементов на нечетных позициях массива. 2 вариант
/*int SumEvenPosition (int[] array){
    int sum = 0;
    for (int i = 0; i < array.Length; i++){
        if (i % 2 != 0){
            sum += array[i];
        }
    }
    return sum;    
    }*/











//Метод задания массива
int[] GetArray (int size, int min, int max){
    int[] res = new int[size];
    for (int i = 0; i < size; i++){
        res[i] = new Random().Next(min, max+1);
    }
    return res;
}