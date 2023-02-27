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

void GetSecondNumbers(string[] array1, string[] array2)
{
    int count = 0;
    for(int i = 0; i < array1.Length; i++)
    {
        if(array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
    if (count == 0)
    {
            Console.WriteLine("Нет слов меньше трех символов");
    }
}
void PrintArray(string[] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
            Console.Write("{0,8:F2}", $"{inArray[i]}\t "); 
    }
}

Console.Clear();
Console.WriteLine("Введите слова или числа через запятую:");

StringBuilder readWords = new StringBuilder(Console.ReadLine());
string[] array = readWords.Replace(",", " ").ToString().Split(" ",StringSplitOptions.RemoveEmptyEntries);   //заменяем "," на пробелы, а потом пробелы являются разделителями в строке
//Console.WriteLine(string.Join(", ",array));
string[] array2 = new string [array.Length];

GetSecondNumbers(array, array2);
//Console.WriteLine("Из введенных данных, мы получили массив из строк, которые меньше или равны 3 символам");
PrintArray(array2);

