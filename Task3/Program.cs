/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/


int ReadInt(string arg)
{
    System.Console.Write($"Введите {arg}");
    return int.Parse(Console.ReadLine());
}


double[] CreateArray(int Length)
{
    double[] numbers = new double[Length];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Math.Round((new Random().NextDouble()*10), 2);
    }
    return numbers;
}


void PrintArray (double[] numbers)
{
    System.Console.Write("[");
    for (int i = 0; i < numbers.Length-1; i++)
    {
        System.Console.Write(numbers[i] + "; ");
    }
    System.Console.WriteLine(numbers[numbers.Length-1] + "]");
}


double MinNumb(double[] numbers)
{
    int i = 0;
    double min = numbers[i];
    while (i < numbers.Length)
     {
         if (numbers[i] < min)
         {
             min = numbers[i];
         }
         else i++;
     }
     return min;
}


double MaxNumb(double[] numbers)
{
    int i = 0;
    double max = numbers[i];
    while (i < numbers.Length)
     {
         if (numbers[i] > max)
         {
             max = numbers[i];
         }
         else i++;
     }
     return max;
}


void DiffOfNumbers(double[] numbers, double min, double max)
{
    min = MinNumb(numbers);
    max = MaxNumb(numbers);
    double result = max - min;
    System.Console.WriteLine($"Разница между максимальным и минимальным значением массива = {result}");
}


int Length = ReadInt("длину массива: ");
double[] numbers = CreateArray(Length);
PrintArray (numbers);
double min = MinNumb(numbers);
double max = MaxNumb(numbers);
System.Console.WriteLine($"Минимальное значение массива = {min}");
System.Console.WriteLine($"Максимальное значение массива = {max}");
DiffOfNumbers(numbers, min, max);