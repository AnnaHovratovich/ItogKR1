﻿// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


string[] CreateArray(int size) 
{
    string[] array = new string[size];
    for (int i = 0; i < array.Length; i++) 
    { 
        array[i] = Console.ReadLine(); 
    } 
    return array;     
}


void PrintArray(string[] array) 
{ 
    Console.Write("["); 
    for (int i = 0; i < array.Length; i++) 
    { 
        if (i < array.Length - 1) Console.Write($"'{array[i]}', "); 
        else Console.Write($"'{array[i]}'"); 
    } 
    Console.Write("]"); 
}


int SizeArrayLenthOfElementsUpTo (string[] array, int elementSize)
{
    int array2Size=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= elementSize)
        {
            array2Size++;
        } 
    }
    return array2Size;
}


string[] ArrayLenthOfElementsUpTo (string[] array, int elementSize) 
{
    int array2Size=SizeArrayLenthOfElementsUpTo(array, elementSize);           
    string []array2=new string [array2Size];
    int array2Index=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= elementSize)
        {
            array2[array2Index]=array[i];
            array2Index++;
        }  
    } 
    return array2;
}


Console.WriteLine("Введите количество элементов массива: ");
int lengthMas= Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите элементы массива: ");
string []massive=CreateArray(lengthMas);
PrintArray(massive);
Console.Write(" -> ");
int sizeElement=3;
string []newMassive=ArrayLenthOfElementsUpTo(massive, sizeElement);
PrintArray(newMassive);
Console.WriteLine();
