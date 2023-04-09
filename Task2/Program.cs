/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int ReadInt(string arg)
{
    System.Console.Write($"Введите {arg}");
    return int.Parse(Console.ReadLine());
}


int[] CreateArray(int Length, int min, int max)
{
    int[] numbers = new int[Length];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(min, max);
    }
    return numbers;
}


void PrintArray (int[] numbers)
{
    System.Console.Write("[");
    for (int i = 0; i < numbers.Length-1; i++)
    {
        System.Console.Write(numbers[i] + "; ");
    }
    System.Console.WriteLine(numbers[numbers.Length-1] + "]");
}

void Sum(int[] numbers)
{
    int i = 0;
    int x = 0;
    int result = 0;

    while (i < numbers.Length+1)
    {
        if (x != i % 2)
        {
            result += numbers[i];
            i+=2;
        }
        else 
        {
            i++;
        }
    }
    System.Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {result}");
}

int Length = ReadInt("длину массива: ");
int min = ReadInt("минимальное значение: ");
int max = ReadInt("максимальное значение: ");
int[] numbers = CreateArray(Length, min, max);
PrintArray(numbers);
Sum(numbers);
