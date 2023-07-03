/*Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*/
using System;
using static System.Console;
string[] ChoiseElement(string[] array, int maxLength)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        count += array[i].Length <= maxLength ? 1 : 0;
    string[] result = new string[count];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxLength)
        {
            result[j] = array[i];
            j++;
        }
    }
    return result;
}
string[] array = { "Text", "Home", "To", "Do", "5", "six", "seven" };
Write($"{String.Join(" ",array)} ==>");
string[] array1 = ChoiseElement(array, 3);
WriteLine(String.Join(" ",array1));