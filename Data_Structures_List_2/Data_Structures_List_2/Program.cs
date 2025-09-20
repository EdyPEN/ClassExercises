// Please to test un-comment each exercise individually (sorry for the inconvenience)

#region Exercise 1

//Create a recursive function that receives a positive integer N and prints all natural numbers from
//0 to N in ascending order

//int i = 0;

//void NaturalNumberRecursion(int n)
//{
//    if (i <= n)
//    {
//        Console.WriteLine(i);
//        i++;
//        NaturalNumberRecursion(n);
//    }
//    else
//        i = 0;
//}

//NaturalNumberRecursion(10);

#endregion

#region Exercise 2

//Create a recursive function that sums up the elements of an integer array.

//int[] x = [1, 4, 9, 16, 25];
//int y = 0, i = 0;

//void SummingNumbersRecursion(int[] x)
//{
//    if (i <= (x.Length - 1))
//    {
//        y += x[i];
//        i++;
//        SummingNumbersRecursion(x);
//    }
//    else
//        Console.WriteLine(y);
//}

//SummingNumbersRecursion(x);

#endregion

#region Exercise 3

//Create a recursive function that receives a positive integer N and calculates the sum of the
//numbers from 1 to N.

//int x = 1, y = 0;

//void SumOfNumbersFromOne(int n)
//{
//    if (x <= n)
//    {
//        y += x;
//        x++;
//        SumOfNumbersFromOne(n);
//    }
//    else
//        Console.WriteLine(y);
//}

//SumOfNumbersFromOne(10);

#endregion

#region Exercise 4

//Create a recursive function that reverses a string. For example, if the input is "hello", the output
//should be "olleh".

//int i = -2;
//string drow = "";

//void StringReverser(string word)
//{
//    if (i == -2)
//    {
//        i = word.Length - 1;
//        StringReverser(word);
//    }
//    else if (i >= 0)
//    {
//        drow = drow + word[i];
//        i--;
//        StringReverser(word);
//    }
//    else
//        Console.WriteLine(drow);
//}

//StringReverser("hello");

#endregion

#region Exercise 5

//Create a recursive function that receives a positive integer N and returns the factorial of that
//number.

//int i = 1, x = 1;
//void FacorialRecursion(int n)
//{
//    if (i <= n)
//    {
//        x *= i;
//        i++;
//        FacorialRecursion(n);
//    }
//    else
//        Console.WriteLine(x);
//}

//FacorialRecursion(5);

#endregion

#region Exercise 6

//The superfactorial of a number N is defined by the product of the first N factorials of N. Thus, the
//superfactorial of 4 is sf (4) = 1! * 2! * 3! * 4! = 288
//Use previous recursive factorial function to implement this one.

//int i = 1, j = 1, x = 1;
//void SuperFacorialRecursion(int n)
//{
//    if (j <= n)
//    {
//        if (i <= j)
//        {
//            x *= i;
//            i++;
//            SuperFacorialRecursion(n);
//        }
//        else
//        {
//            i = 1;
//            j++;
//            SuperFacorialRecursion(n);
//        }
//    }
//    else
//        Console.WriteLine(x);
//}

//SuperFacorialRecursion(4);

#endregion

#region Exercise 7
//Tetranacci numbers start with four predetermined terms and from there all other numbers are
//obtained by summing the previous four numbers. The first tetranacci numbers are: 0, 0, 0, 1, 1, 2,
//4, 8, 15, 29, 56, 108, 208... Create a recursive function that receives a number N and returns the
//Nth term in the tetranacci sequence.

//int[] x = [0, 0, 0, 1];
//int i = 0, y = 0;


//void TetanacciSequence(int n)
//{
//    if ((i + 1) <= (n - 4))
//    {
//        y = x[i] + x[i + 1] + x[i + 2] + x[i + 3];
//        x = x.Append(y).ToArray();
//        i++;
//        TetanacciSequence(n);
//    }
//    else
//        Console.WriteLine(y);
//}

//TetanacciSequence(10);


#endregion

#region Exercise 8
//Write a recursive function that calculates the sum of the first n cubes:
//S(n) = 1³ +2³ +... +n³

//int i = 1, x = 0;

//void RecursiveCubes(int n)
//{
//    if (i <= n)
//    {
//        x += (int)Math.Pow(i, 3);
//        i++;
//        RecursiveCubes(n);
//    }
//    else
//        Console.WriteLine(x);
//}

//RecursiveCubes(3);

#endregion

#region Exercise 9

//Write a recursive function that calculates the sum of the digits of an integer. For example, if the
//input is 123, the output should be 1+2+3 = 6.

//int x = 0;

//void DigitSum(int n)
//{
//    if (n > 0)
//    {
//        x += (n % 10);
//        n = n / 10;
//        DigitSum(n);
//    }
//    else
//        Console.WriteLine(x);
//}

//DigitSum(345);

#endregion

#region Exercise 10

// Pell numbers are defined by the following recursion:

//P0 = 0,
//P1 = 1,
//Pn = 2Pn-1 + Pn-2.

//Some numbers in this sequence are: 0, 1, 2, 5, 12, 29, 70, 169, 408, 985...
//Create a recursive function that receives a number N and returns the Nth Pell number.

//int[] x = [0, 1];
//int i = 2;

//void PellNumbersRecursion(int n)
//{
//    if (n > 1)
//    {
//        if (i <= n)
//        {
//            x = x.Append(2 * x[i - 1] + x[i - 2]).ToArray();
//            i++;
//            PellNumbersRecursion(n);
//        }
//        else
//            Console.WriteLine(x[n]);
//    }
//    else
//        Console.WriteLine(n);
//}

//PellNumbersRecursion(7);


#endregion