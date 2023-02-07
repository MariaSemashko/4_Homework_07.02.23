/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

// Делаю два разных метода: для получения любого числа A типа double и натурального числа B типа int

double GetNumberA(string message)
{
    double result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (double.TryParse(Console.ReadLine(), out result))
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

int GetNumberB(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
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

double GetPow(double numberA, int numberB)
{
    double pow = Math.Pow(numberA, numberB);
    return pow;
}

double numberA = GetNumberA("Введите любое число");
int numberB = GetNumberB("Введите натуральное число");
double pow = GetPow(numberA, numberB);

Console.WriteLine($"Число {numberA} в натуральной степени {numberB} = {pow}");
