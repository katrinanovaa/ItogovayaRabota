/*Задача

Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется использовать коллекции,
лучше обойтись исключительно массивами.

Например:
{"hello", "2", "world", ":-)"}  -> {"2", ":-)"}
{"1234", "1567", "-2", "computer science"}  -> {"-2"}
{"Russia", "Denmark", "Kazan"}  -> {}*/

using System.Text;     // используем using для работы со строками

string[] FindWords(string[] array1)
{
    int stringLength = 3;     // задаем длину отбора строк в методе. При желании можно сделать ввод в консоли
    StringBuilder readWords = new StringBuilder();
    for(int i = 0; i < array1.Length; i++)
    {
        if(array1[i].Trim().Length <= stringLength)
        {
            readWords.Append(array1[i].Trim());
            readWords.Append(",");
        }
    }
        string[] array = readWords.ToString().Split(",",StringSplitOptions.RemoveEmptyEntries);  
    return array;
}

Console.Clear();
Console.WriteLine("Введите слова или числа через запятую:");

StringBuilder readWords = new StringBuilder(Console.ReadLine()!);
string[] array = readWords.ToString().Split(",",StringSplitOptions.RemoveEmptyEntries);   //заменяем "," на пробелы, а потом пробелы являются разделителями в строке
string[] array2 = FindWords(array);

if (array2.Length == 0)
{
    Console.WriteLine("Нет длины меньше трех символов");
} else {
    Console.WriteLine("Из введенных данных, мы получили массив из строк, которые меньше или равны 3 символам");
    Console.WriteLine(string.Join(",", array2));
    
}