/*Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/


int GetNumber(string message)
{
    while (true)
    {
        Console.WriteLine(message);
        string? num = Console.ReadLine();
        if (int.TryParse(num, out int number) == false)
            Console.WriteLine("Введено не число");
        else
        {
            if (number <= 0)
                Console.WriteLine("Задайте число больше 0");
            else
                return number;
        }
    }
}

double[,] ArrayRandom(int line, int column)
{
    double[,] arr = new double[line, column];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            arr[i, j] = rnd.NextDouble();
    }
    return arr;
}

void PrintArray(double[,] arr)
{
    Console.WriteLine("Двумерный массив, заполненный случайными вещественными числами:");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j]:0.000} ");
        Console.WriteLine();
    }

}

int line = GetNumber("Задайте чиcло строк m: ");
int column = GetNumber("Задайте число столбцов n: ");
double[,] rnd = ArrayRandom(line, column);
PrintArray(rnd);
