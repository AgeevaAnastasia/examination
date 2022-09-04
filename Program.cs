using System;
// написать программу, которая из имеющегося массива строк формирует массив строк, 
// длина которых меньше или равна трем символам. 

string[] array = {"hello", "2", "world", ":-)", "red", "1234", "-2", "computer science", "Kazan", "Russia"};


Console.Clear();
string[] arrayNew = FilterArray(array);

PrintArray(arrayNew);



string[] FilterArray(string[] arr)
{
    int size = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) size += 1;
    }
    string[] arrNew = new string[size];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            arrNew[j] = arr[i];
            j++;
        }  
    }
    return arrNew;
}


void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i != arr.Length - 1) 
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}
