// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int Length = ReadInt("длину массива: ");
int min = ReadInt("минимальное значение: ");
int max = ReadInt("максимальное значение: ");
int[] numbers = CreateArray(Length, min, max);
PrintArray(numbers);
FindNumbers(numbers);


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


void FindNumbers(int[]numbers)
{
    int j = 0;
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
       if (j == numbers[i] % 2)
       {
            count++;
       }
    }
    System.Console.WriteLine($"В массиве {count} четных чисел");
}