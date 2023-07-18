// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4-> 16

 int Prompt(string message) //Пишем передаваемое сообщение - запрашиваем у пользователя число - на выходе выдаем это число
{
     Console.Write(message);
     int num = int.Parse(Console.ReadLine()!);
     return num;
}

int Power(int PowerBase, int Exponent)
{
    int power = 1;
    for (int i = 0; i < Exponent; i++)
    {
        power *= PowerBase;
    }
    return power;
}

bool ValidateExponent(int Exponent)
{
    if (Exponent < 0)
    {
        Console.WriteLine("Показатель не должен быть мнеьше нуля");
        return false;
    }
    return true;
}

int PowerBase = Prompt("Введите основание:");
int Exponent = Prompt("Введите показатель: ");
if (ValidateExponent(Exponent))
{
    Console.WriteLine($"Число {PowerBase} в степени {Exponent} равно {Power(PowerBase, Exponent)}");
}