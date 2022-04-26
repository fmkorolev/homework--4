/*
int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }

    Console.WriteLine();
}


// задача 36
/*
int[] minearray = CreateRandomArray(4, -99,99);
ShowArray(minearray);
void SumOfOddPositions(int[] array)
{
    int sumOdd = 0;
    for(int i = 1; i < array.Length; i += 2)
    {
        sumOdd += array[i];
    }
    Console.Write("Sum of odd positions: " + sumOdd);
}
SumOfOddPositions(minearray);

/*

// задача 34
/*
void NumberOfEvenNumbers(int[] array)
{
    int even = 0;
    for(int i = 0; i< array.Length; i++)
    {
        if(array[i] % 2 == 0)
            even++;
    }
    Console.Write("Number of even numbers: " + even);
}
int[] myarray = CreateRandomArray(4, 100, 999);
ShowArray(myarray);
NumberOfEvenNumbers(myarray);
*/
// Задача 38
 class Program
 {
        static void Main(string[] args)
 {
     Random rnd = new Random();
    int[] d = new int[30];
    int max=0, min=100;
    for (int i = 0; i<d.Length; i++ )  d[i] = rnd.Next(100);
    for (int i = 0; i < d.Length; i++)
{
     if (d[i] > max) max = d[i];
     if (d[i] < min) min = d[i];
 }
           
     for (int i = 0; i < d.Length; i++) Console.Write(" "+d[i]);//выводим массив
     Console.WriteLine();
    Console.WriteLine("max:  " + max);
    Console.WriteLine("min  " +min);
    Console.WriteLine("Разница максимального и минимального:  "+(max - min));
    Console.ReadKey();
        }
    }
