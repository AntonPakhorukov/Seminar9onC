/*
Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N с помощью рекурсии
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
Задача 65: Задайте значения M и N. Напишите программу, которая выведет все 
натуральные числа в промежутке от M до N с помощью рекурсии
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6, 7, 8"
*/
/*
Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int index = 0;
void PrintNumber(int inputNumber, int index) {
    index++;
    if (index != inputNumber) {
        
        PrintNumber(inputNumber,index);
    }
    Console.Write(index + ", ");
}
PrintNumber(number, index);
Console.WriteLine();
///////////////////////////////////
Console.Write("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int index1 = 1;
void PrintNumber1(int inputNumber, int index) {
    inputNumber--;
    if (index != inputNumber + 1) {
        
        PrintNumber1(inputNumber,index);
    }
    Console.Write((inputNumber + 1) + ", ");
}
PrintNumber1(number1, index1);
/////////////////////////////////////////
*/
Console.Write("Введите число: ");
int number3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int number4 = Convert.ToInt32(Console.ReadLine());
void PrintMN (int number3, int number4) {
    Console.Write(number3 + ", ");
    number3++;
    if (number3 == number4) {
        Console.Write(number4);
        return;
    } else {
        PrintMN(number3, number4);
    }
}
PrintMN(number3, number4);