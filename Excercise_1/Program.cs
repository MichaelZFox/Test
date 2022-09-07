// Задача: Написать программу, 
// которая из имеющегося массива строк 
// формирует массив из строк, длина которых 
// меньше либо равна 3м символам. 
// Первоначальный массив можно ввести ввести с клавиатуры, 
// либо задавать на старте выполнения алгоритма. 
// При решения не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно масивами.

// ["hello", "2", "word", ":-)"] -> ["2", ":-)"]
// ["1234, "1567", "-2", "computer scinece"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

string[] array1 = new string[] { "hello", "2", "word", ":-)" };
string[] array2 = new string[array1.Length];

void SortArray(string[] arr1, string[] arr2)
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
void PrintArray(string[] arr)
{
    Console.Write("[")
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine("]");
}


SortArray(array1, array2);
PrintArray(array2);

string[] arraySecond1 = new string[] {"1234", "1567", "-2", "computer scinece"};
string[] arraySecond2 = new string[arraySecond1.Length];

SortArray(arraySecond1, arraySecond2);
PrintArray(arraySecond2);

string[] arrayThrid1 = new string[] {"Russia", "Denmark", "Kazan"};
string[] arrayThrid2 = new string[arrayThrid1.Length];

SortArray(arrayThrid1, arrayThrid2);
PrintArray(arrayThrid2);
