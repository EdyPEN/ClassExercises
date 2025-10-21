using System.Numerics;
using System.Runtime.InteropServices;

#region Exercise 1

//int[] numbers = [89, 17, 65, 20, 72, 36, 23, 19, 50, 39];

// a)

//int i = 0;
//bool found = false;

//for (i = 0; i <= 9; i++)
//{
//    if (numbers[i] == 50)
//    {
//        found = true;
//        Console.WriteLine("Found");
//        break;
//    }
//}
//if (found == false)
//{
//    Console.WriteLine("Not found");
//}

// b)

//int i = 0, count = 0;

//for (i = 0; i <= 9; i++)
//{
//    if (numbers[i] == 50)
//    {
//        count = count + 1;
//    }
//    if (i == 9)
//        Console.WriteLine(count);
//}

// c)

//int i = 0;
//float average = 0.0f;

//for (i = 0; i <= 9; i++)
//{
//    average += numbers[i];
//    if (i == 9)
//    {
//        average /= 10;
//        Console.WriteLine(average);
//    }
//}

// d)

//int i = 0, minimum, maximum;

//minimum = maximum = numbers[0];

//for (i = 1; i <= 9; i++)
//{
//    if (numbers[i] < minimum)
//    {
//        minimum = numbers[i];
//    }
//    if (numbers[i] > maximum)
//    {
//        maximum = numbers[i];
//    }
//}

//Console.WriteLine("Maximum = " + maximum);
//Console.WriteLine("Minimum = " + minimum);

// e)

//int i = 0, sum = 0, product = 1;

//for (i = 1; i <= 9; i++)
//{
//    sum += numbers[i];
//    product *= numbers[i];
//}

//Console.WriteLine("sum = " + sum);
//Console.WriteLine("product = " + product);

// f)

//int i = 0;


//for (i = 9; i >= 0; i--)
//{
//    Console.Write(" " + numbers[i]);
//}

// g)

//int i = 0;

//int[] reversedNumbers = new int[10];

//for (i = 9; i >= 0; i--)
//{
//    reversedNumbers[9 - i] = numbers[i];
//}

//if (reversedNumbers[9] == numbers[0])
//{
//    for (i = 0; i <= 9; i++)
//    {
//        Console.WriteLine(reversedNumbers[i]);
//    }
//}

// h)

//int i = 0;

//int[] evenNumbers = [];
//int[] oddNumbers = [];

//for (i = 0; i <= 9; i++)
//{
//    if ((numbers[i] % 2) == 0)
//    {
//        evenNumbers = evenNumbers.Append(numbers[i]).ToArray();
//    }
//    else
//    {
//        oddNumbers = oddNumbers.Append(numbers[i]).ToArray();
//    }
//}

//for (i = 0; i <= evenNumbers.Length - 1; i++)
//{
//    Console.WriteLine("Even " + (i + 1) + " " + evenNumbers[i]);
//}

//for (i = 0; i <= oddNumbers.Length - 1; i++)
//{
//    Console.WriteLine("Odd " + (i + 1) + " " + oddNumbers[i]);
//}

#endregion

#region Exercise 2

//int n, currentNumber;

//Console.WriteLine("Hey pick a number yo");
//n = int.Parse(Console.ReadLine());
//int[] numberArray = new int[n], productArray = new int[n];


//Console.WriteLine("Now which numbers should be in the array?");
//for (int i = 0; i < n; i++)
//{
//    currentNumber = int.Parse(Console.ReadLine());
//    numberArray[i] = currentNumber;
//}

//Console.Write("Alright here's your funny stuff: ");

//for (int i = 0; i < numberArray.Length; i++)
//{
//    productArray[i] = numberArray[i] * i;
//    Console.Write(productArray[i] + " ");
//}

#endregion

#region Exercise 3

//int[] throws = new int[int.Parse(Console.ReadLine())];
//float[] face = new float[6];

//Random random = new Random();

//for (int i = 0; i < throws.Length; i++)
//{
//    face[random.Next(0, 6)]++ ;
//}


//for (int i = 0; i < face.Length; i++)
//{
//    float percentage = face[i] / throws.Length;
//    Console.WriteLine("Face " + i + ": " + face[i] + "(" + percentage.ToString("0.00%") + ")");
//}

#endregion

#region Exercise 4



#endregion