/// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо ровна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Write("Введите размер массива: ");
int sizeArr = Convert.ToInt32(Console.ReadLine());

// Проверка
if(sizeArr <= 0)
{
    Console.WriteLine("Некорректный ввод!");
    return;
}

// Создание массивов
string[] array = new string[sizeArr];
string[] newArr = new string[array.Length];

// Заполнение массива
void FillArray(string[] arr)
{
    Console.WriteLine("Введите элементы массива: ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Элемент № [{i + 1}] = ", i);
        arr[i] = (Console.ReadLine()!);
    }
}

// Вывод массива
void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}  ");
    }
}

// Создание нового массива с выполнением условия
void EndArray(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= 3)
        {
            arr2[count] = arr1[i];
            count++;
        }
    }
}

FillArray(array);
Console.Write("Первичный массив -> ");
PrintArray(array);
Console.WriteLine();
EndArray(array, newArr);
Console.Write("Конечный массив -> ");
PrintArray(newArr);