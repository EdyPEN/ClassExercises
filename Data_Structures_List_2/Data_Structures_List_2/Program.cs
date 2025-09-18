// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region Exercise 1

//Create a recursive function that receives a positive integer N and prints all natural numbers from
//0 to N in ascending order

int incrementalNaturalNumber = 0;

void NaturalNumberRecursion(int n)
{
    if (incrementalNaturalNumber <= n)
    {
        Console.WriteLine(incrementalNaturalNumber);
        incrementalNaturalNumber++;
        NaturalNumberRecursion(n);
    }
    else
        incrementalNaturalNumber = 0;
}

NaturalNumberRecursion(10);

#endregion

#region Exercise 2

//Create a recursive function that sums up the elements of an integer array.

//int[] x = [1, 4, 9, 16, 25];
//int y = 0, i = 0;

//int SummingNumbersRecursion(int[] x)
//{
//    if (i <= (x.Length - 1))
//    y = y + x[i];
//    return y;
//}

#endregion

#region Exercise 3

#endregion

#region Exercise 4

#endregion

#region Exercise 5

#endregion

#region Exercise 6

#endregion

#region Exercise 7

#endregion

#region Exercise 8

#endregion

#region Exercise 9

#endregion

#region Exercise 10

#endregion