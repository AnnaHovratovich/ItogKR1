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




Console.WriteLine("Введите количество элементов массива: ");
int lengthMas= Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите элементы массива: ");
string []massive=CreateArray(lengthMas);