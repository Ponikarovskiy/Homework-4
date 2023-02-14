// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

/*
Console.Clear();
System.Console.WriteLine();
System.Console.WriteLine("*Задача № 25. Возведение в степень*");
System.Console.WriteLine();
int A = NumberA("Введите число А: ", "Ошибка ввода"); 
int B = NumberB("Введите число B: ", "Ошибка ввода"); 
int result = GetResult(A, B);
System.Console.WriteLine();
System.Console.WriteLine($"Ответ: {result}");
System.Console.WriteLine();


int NumberA(string A, string errorMessage)
{
    while (true)
    {
        System.Console.WriteLine(A);
        bool CorrectA = int.TryParse(Console.ReadLine(), out int userNumberA);
        if (CorrectA)
            return userNumberA;
        System.Console.WriteLine(errorMessage);
    }
}

int NumberB(string B, string errorMessage)
{
    while (true)
    {
        System.Console.WriteLine(B);
        bool CorrectB = int.TryParse(Console.ReadLine(), out int userNumberB);
        if (CorrectB)
            if (userNumberB >= 0)
                return userNumberB;
        System.Console.WriteLine(errorMessage);
    }
}

int GetResult(int a, int b)
{
    int result = 1;
    for (int i = 0; i < b; i++)
    {
        result = result * A;
    }
    return result;
}
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
/*
Console.Clear();
System.Console.WriteLine();
System.Console.WriteLine("*Задача № 27. Сумма цифр в числе*");
System.Console.WriteLine();
int number = GetNumber("Введите число: ", "Ошибка ввода"); 
int result = SumDigit(number); 
System.Console.WriteLine();
System.Console.WriteLine($"Ответ: {result}");
System.Console.WriteLine();

int GetNumber(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool CorrectNumber = int.TryParse(Console.ReadLine(), out int userNumber);
        if (CorrectNumber)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int SumDigit(int number)
{ 
    int result = 0;
    int Number = Math.Abs(number);
    while(Number > 0)
    {
        result += Number % 10;
        Number = Number / 10;
    }
    return result;
}
*/


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, -5, 0, -11 -> [1, 2, 5, 7, 19, -5, 0, -11]

Console.Clear();
System.Console.WriteLine();
System.Console.WriteLine("*Задача № 29. Массив*");
System.Console.WriteLine();
int[] arr = CreateArray(8);
Fill(arr);
Console.WriteLine(Print(arr));
System.Console.WriteLine();


int[] CreateArray(int count)
{
    return new int[count];
}

void Fill(int[] elements)
{
    int length = elements.Length;
    int i = 0;
    while (i < length)
    {
        while (true)
        {
            Console.WriteLine($"Введите {i}-й элемент массива: ");
            bool correctNumber = int.TryParse(Console.ReadLine(), out int userNumber);
            if (correctNumber)
            {
                elements[i] = userNumber;
                break;
            }
            Console.Write("Ошибка ввода");
        }
        i++;
    }
}

string Print(int[] collection)
{
    string output = String.Empty;
    for (int i = 0; i < collection.Length; i++)
    {
        int current = collection[i];
        output = output + $"{current}, ";
        if (i == collection.Length)
            output = output + $"{current} ";
    }
    return $"{output} -> [{output}]";
}