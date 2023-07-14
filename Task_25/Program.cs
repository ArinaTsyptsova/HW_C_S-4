// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Degree(int numA, int numB)
{
    int result = 1;
    for (int i = 0; i < numB; i++)
    {
        result *= numA;
    }
    return result;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int numA = GetInput("Введите число A: ");
int numB = GetInput("Введите число B: ");

int degreeNumA = Degree(numA, numB);
Console.WriteLine($"{numA}, {numB} -> {degreeNumA}");