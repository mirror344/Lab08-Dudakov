//Задание 1
// PrintLine();
// Console.WriteLine("Отчёт");
// PrintLine();

// PrintHeader("Title");
// PrintHeader("Void");

// static void PrintLine()
// {
//     Console.WriteLine("^_^");
// }

// static void PrintHeader(string title)
// {
//     PrintLine();
//     Console.WriteLine($"{title}");
//     PrintLine();
// }

//Задание 2.1

// Console.WriteLine(Max(3, 5));
// Console.WriteLine(Max(10, 3));
// Console.WriteLine(Max(5, 5));

// static int Max(int a, int b)
// {
//     int result = a >= b ? a : b;
//     return result;
// }

//Задание 2.2
// Console.WriteLine(IsEven(4));
// Console.WriteLine(IsEven(7));
// Console.WriteLine(IsEven(0));

// static bool IsEven(int n)
// {
//     return n % 2 == 0;
// }

// Задание 3
// int[] numbers = { 120, 45, 300, 80, 15, 210 };
// Console.WriteLine(Average(numbers));
// Console.WriteLine(CountGreater(numbers, 100));
// static double Average(int[] arr)
// {
//     int sum = 0;
//     foreach (int x in arr)
//     {
//         sum += x;
//     }

//     return (double)sum / arr.Length;
// }

// static int CountGreater(int[] arr, int limit)
// {
//     int count = 0;
//     foreach (int x in arr)
//     {
//         count += x > limit ? 1 : 0;
//     }
//     return count;
// }

//Задание 4
// double c1 = 0;
// Console.WriteLine($"{c1} °С = {ToFahrenheit(c1)} °F");

// double c2 = 100;
// Console.WriteLine($"{c2} °С = {ToFahrenheit(c2)} °F");

// double c3 = 37;
// Console.WriteLine($"{c3} °С = {ToFahrenheit(c3)} °F");

// static double ToFahrenheit(double celsius)
// {
//     return celsius * 9 / 5 + 32;

// }


//Задание 5 
// using System.Runtime.Serialization.Formatters;

// Console.WriteLine(Factorial(5));
// for (int i = 2; i < 50; i++)
// {
//     Console.WriteLine($"{i} - {IsPrime(i)}");
// }

// static long Factorial(int n)
// {
//     long result = 1;
//     for (long i = 1; i <= n; i++)
//     {
//         result *= i;
//     }
//     return result;
// }

// static bool IsPrime(int n)
// {
//     int dels = 2;
//     for (int i = 2; i <= n - 1; i++)
//     {
//         if (n % i == 0)
//         {
//             dels += 1;
//         }
//     }

//     return dels == 2;
// }

//Задание 6
// int a = ReadPositive("Введите число a");
// int b = ReadPositive("Введите число b");
// Console.WriteLine($"Сумма: {a+b}");

// static int ReadPositive(string message)
// {
//     Console.WriteLine(message);
//     int num = 0;
//     do
//     {
//         num = int.Parse(Console.ReadLine());
//     } while (num < 0);

//     return num;
// }


//Меню-калькулятор
bool work = true;
while (work)
{
    int choice = ReadPositive("1 - cумма двух чисел \n2 - большее из 2х чисел \n3 - факториал \n0 - выход");

    switch (choice)
    {
        case 0:
            work = false;
            break;
        case 1:
            Console.WriteLine(Sum(ReadPositive("Введите число a"), ReadPositive("Введите число b")));
            break;
        case 2:
            Console.WriteLine(Max(ReadPositive("Введите число a"), ReadPositive("Введите число b")));
            break;
        case 3:
            Console.WriteLine(Factorial(ReadPositive("Введите число")));
            break;
        default:
            Console.WriteLine("Нет такого пункта");
            break;
    }
    

}

static int ReadPositive(string message)
{
    Console.WriteLine(message);
    int num = 0;
    do
    {
        num = int.Parse(Console.ReadLine());
    } while (num < 0);

    return num;
}

static long Factorial(int n)
{
    long result = 1;
    for (long i = 1; i <= n; i++)
    {
        result *= i;
    }
    return result;
}

static int Max(int a, int b)
{
    int result = a >= b ? a : b;
    return result;
}

static int Sum(int a, int b)
{
    return a + b;
}


// Дополнительные задание
// Console.WriteLine(Gcd(48, 18));
// Console.WriteLine(Lcm(4, 6));
// static  int Gcd(int a, int b) {
//     while (b != 0) {
//         int x = b;
//         b = a % b;
//         a = x;

//     }
//     return a;
// }

// static int Lcm(int a, int b) {
//    return a / Gcd(a, b) *b;
// }
