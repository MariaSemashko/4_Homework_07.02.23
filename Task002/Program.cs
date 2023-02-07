/*  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число или не корректное число.");
        }
    }

    return result;
}

int GetDigitSum(int number)
{
    int digitsum = 0;
    int remainder = 0;
    int numberdiv = Math.Abs(number);
    
    while (numberdiv > 10)
    {
        remainder = numberdiv % 10;
        digitsum = digitsum + remainder;
        numberdiv = numberdiv / 10;
    }
    digitsum = digitsum + numberdiv;
    return digitsum;
}

int number = GetNumber("Введите целое число");
int result = GetDigitSum(number);
Console.WriteLine($"Сумма цифр в числе {number} = {result}");
