﻿string[] array = new string[4] {"Hello", "2", "world", ":-)"};
string[] arrayNew = new string[array.Length];

void CheckArray(string[] array, string[] arrayNew)
{
    int result = 0;
    int length = 3;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= length) 
        {
            arrayNew[result] = array[i];
            result++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

CheckArray(array, arrayNew);
PrintArray(arrayNew);

