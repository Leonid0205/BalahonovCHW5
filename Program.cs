//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateMass(int size)
{
    int[] mass = new int[size];
    for(int i = 0; i < size; i++)
    {
        mass[i] = new Random().Next(100, 1000);
    }
    return mass;
}
void ShowMass(int[] mass)
{
    for(int i = 0; i < mass.Length; i++)
    {
        Console.Write($"{mass[i]} ");
    }
    Console.WriteLine();
}
int ShowEvenNumbers(int[] mass)
{
    int count = 0;
    for(int i = 0; i < mass.Length; i++)
    {
        if(mass[i] % 2 == 0) count++;
    }
    return count;
}
Console.Write("Input size of a massive: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] mass = CreateMass(size);
ShowMass(mass);
Console.WriteLine($"The quantity of even numbers is: {ShowEvenNumbers(mass)}");
Console.WriteLine();

//Задайте массив, заполненный случайными числами. Найдите сумму элементов,
//стоящих на нечётных позициях.

int[]  CreateMass2(int size2)
{
    int[] mass2 = new int[size2];
    for(int i = 0; i < size2; i++)
    {
        mass2[i] = new Random().Next(-9, 10);
    }
    return mass2;
}
void ShowMass2(int[] mass2)
{
    for(int i = 0; i < mass2.Length; i++)
    {
        Console.Write($"{mass2[i]}  ");
    }
    Console.WriteLine();
}
void SumOfUnevenNumbers(int[] mass2)
{
    int sum = 0;
    for(int i = 0; i < mass2.Length; i = i + 2)
    {
        sum = sum + mass2[i];
        //var n = mass2[i];
        //Console.WriteLine($"m[i] {n}");
        //Console.WriteLine($"sum {sum}");
    }
    Console.WriteLine($"The sum of uneven numbers is: {sum}");
}
Console.Write("Input size of a massive: ");
int size2 = Convert.ToInt32(Console.ReadLine());
int[] mass2 = CreateMass2(size2);
ShowMass2(mass2);
SumOfUnevenNumbers(mass2);
Console.WriteLine();

//Задайте массив вещественных чисел. Найдите разницу между максимальным и 
//минимальным элементов массива.

double[] CreateArray(int size)
{
    double[] mass = new double[size];
    for(int i = 0; i < size; i++)
    {
        mass[i] = new Random().Next(0, 10) + new Random().NextDouble();
    }
    return mass;
}
void ShowArray(double[] mass)
{
    for(int i = 0; i < mass.Length; i++)
    {
        Console.Write($"{mass[i]} ");
    }
    Console.WriteLine();
}
void DifferenBetweenMaxAndMin(double[] mass)
{
    double difference = 0;
    double min = mass[0];
    double max = mass[0];
    for(int i = 1; i < mass.Length; i ++)
    {
        if(max < mass[i]) max = mass[i];
        if(min > mass[i]) min = mass[i];
    }
    Console.WriteLine($"max: {max} min: {min}");
    Console.Write($"The difference between max and min element is: {difference = max - min}");
}
Console.Write("Input size of a massive: ");
int size3 = Convert.ToInt32(Console.ReadLine());
double[] mass3 = CreateArray(size3);
ShowArray(mass3);
DifferenBetweenMaxAndMin(mass3);