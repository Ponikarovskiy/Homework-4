// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
System.Console.WriteLine();
System.Console.WriteLine("*Задача № 25. Возведение в степень*");
System.Console.WriteLine();
int A = NumberA("Ведите число А: ", "Ошибка ввода"); 
int B = NumberB("Ведите число B: ", "Ошибка ввода"); 
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

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, -5, 0, -11 -> [1, 2, 5, 7, 19, -5, 0, -11]