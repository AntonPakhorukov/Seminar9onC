/*Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр с помощью рекурсии.
453 -> 12
45 -> 9
Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/
/*Console.Write("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int sum = 0;
void PrintOne(int number, int sum)
{
    if (number > 0)
    {
        sum = sum + (number % 10);
        number = number / 10;
        Console.WriteLine(sum);
        PrintOne(number, sum);
       

    }
    else { 
        return ;
        }
}

PrintOne(number1, sum);
*/

int sum_between_M_and_N(int number, int sum)
{
    if (number < 10)
    {
        sum = sum + number;
        return sum;
    }
    else {
        sum = sum + (number % 10);
        return sum_between_M_and_N(number / 10, sum);
    }
}

//Console.Clear();
Console.Write("Введите число M: ");
int number = int.Parse(Console.ReadLine());

int sum = 0;
sum = sum_between_M_and_N(number, sum);

Console.WriteLine(sum);


int multiplay(int A, int B, int result = 1) 
{
    if (B > 0)
    {
        result = result * A;
        B -= 1;
        return multiplay(A, B, result);
    }
    else return result;
}

Console.Clear();
Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите число В: ");
int B = int.Parse(Console.ReadLine());

Console.WriteLine(multiplay(A, B));

/*
int summ = 0;
void Recurs(int n)
{
    if (n > 0)
    {
        summ += n % 10;
        Recurs(n / 10);
    }

    else
        Console.WriteLine(summ);
    return;
}
*/
/*
int Recurs2(int n, int b)
{
    if (b == 0)
        return 1;
    return n * Recurs2(n, b - 1);
}

System.Console.WriteLine(Recurs2(3, 2));
*/