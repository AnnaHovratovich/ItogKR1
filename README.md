# Итоговая контрольная работа по основному блоку

## Задача: 
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Решение
Пользователь вводит по запросу массив, предварительно указав количество элементов массива (размер исходного массива).

Метод **«CreateArray»** считывает введенные данные и с помощью метода **«PrintArray»** программа выводит его на экран.

Переменная **«sizeElement»** задает искомую длину элементов массива (в данном случае - 3).

С помощью метода **«SizeArrayLenthOfElementsUpTo»** программа считает, сколько элементов исходного массива соответствуют условию (длина меньше или равна 3 символа). Таким образом определяем размер нового массива.

Метод **«ArrayLenthOfElementsUpTo»** позволяет записать в новый массив соответствующие условию элементы и вывести их с помощью метода **«PrintArray»**.