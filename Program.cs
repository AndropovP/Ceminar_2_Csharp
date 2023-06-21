// 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Функция вводит целое значение из консоли
int ReadInt(string message)
{
    Console.Write(message);                             // Ввод приглашения
    int number = Convert.ToInt32(Console.ReadLine());   // Чтение строки и преобразование в число
    return number;                                      // Возврат целого числа
}

bool Validate3sign(int number)
{
    if (number < 100 || number >= 1000)
    {
        Console.WriteLine("Вы ввели не 3-х значное число");
        return false;
    } 
    return true;
}

int digit = ReadInt("Введите 3-х значное число > ");
if (Validate3sign(digit))
{
    int sekondDigit = digit / 10 % 10;
    Console.WriteLine($"Вторая цифра числа {digit} равна {sekondDigit}");
}