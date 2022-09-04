// В ОДНОМЕРНОМ МАССИВЕ ИЗ 123 ЧИСЕЛ НАЙТИ КОЛИЧЕСТВО ЭЛЕМЕНТОВ ИЗ ОТРЕЗКА [10, 99]
Console.Clear();
int size = 123;    // размер массива
int min = -100;    // минимальное число массива
int max = 200;     // максимальное число массива

int[] FillArray(int size, int min, int max)    // метод создания массива
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintCountArray(int[] arr)    // печать массива в консоль
{
    int count = 1;
    Console.WriteLine();
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
        if (arr[i] >= 10 && arr[i] <= 99) count++;
    }
    Console.WriteLine();
    Console.WriteLine($"Количество чисел из диапазона [10, 99] равно {count}");
    Console.WriteLine();
}

PrintCountArray(FillArray(size, min, max));