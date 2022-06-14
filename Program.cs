/*Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.*/

const int strMaxSize = 3;

uint arrSize = InputNumber("Input array size: ");

string[] arr = new string[arrSize];
string[] resultArr = new string[arrSize];

InputArray(arr);

FindNewArray(arr, ref resultArr);

PrintArray(resultArr);

uint InputNumber(string message)
{
    Console.Write(message);
    uint number;

    while (!uint.TryParse(Console.ReadLine(), out number))
    {

        Console.WriteLine("You inputed something wrong! Try again.");
        Console.Write(message);

    }

    return number;
}

void InputArray(string?[] arrayIn)
{
    int arrLength = arrayIn.Length;

    Console.WriteLine($"Input {arrLength} strings:");

    for (int i = 0; i < arrLength; i++)
    {
        Console.Write("-> ");
        arrayIn[i] = Console.ReadLine();
    }

}

void FindNewArray(string[] arrayIn, ref string[] arrayOut)
{
    int arrLength = arrayIn.Length;
    int j = 0;

    foreach (var item in arrayIn)
    {
        if (item.Length <= strMaxSize)
        {
            arrayOut[j] = item;
            j++;
        }
    }

    Array.Resize(ref arrayOut, j);

}

void PrintArray(string[] arrayIn)
{
    int arrLength = arrayIn.Length;

    if (arrLength == 0) 
    {
        Console.WriteLine("[]");
        return;
    }

    Console.Write("[" + arrayIn[0]);

    for (int i = 1; i < arrayIn.Length; i++)
    {
        Console.Write(", " + arrayIn[i]);
    }

    Console.WriteLine("]");
}
