﻿// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
// коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

// Задаем исходный массив

string[] EnterStrings()
{
    Console.WriteLine("Введите количество строк");
    int count = Convert.ToInt32(Console.ReadLine());
    
    string[] array = new string[count];
    Console.WriteLine("Введите строки (через Enter)");
    for (int i = 0; i < count; i++)
    {
    array[i] = Console.ReadLine();
    }
    return array;
}

// Функция для нахождения нового массива
string[] CreateArrayOfStringsLengthLess3(string[] array)
{
    // Определяем размер результирующего массива
    int sizeNewArray = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            sizeNewArray++;
        }
    }

    // Создаем новый массив
    string[] newArray = new string[sizeNewArray];
    int j = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

// Функция вывода массива

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }
    }
    Console.Write("]");
}

string[] array = EnterStrings();

string[] newArray = CreateArrayOfStringsLengthLess3(array);

PrintArray(array);
Console.Write (" → ");
PrintArray(newArray);