// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите количество проверяемых чисел: ");
int index = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < index; i++)
{
    Console.Write("Введите число " + (i + 1) + " = ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 0) count += 1;
}
Console.WriteLine("Количество введенных чисел > 0 равно: " + count);