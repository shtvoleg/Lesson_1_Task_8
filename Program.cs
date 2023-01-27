//    Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();				                // очистка консоли

Console.WriteLine("Введите число: ");		// ввод числа
int num = Convert.ToInt32(Console.ReadLine());

if ( num < 0)                               // если отрицательное значение
    Console.WriteLine($"Число должно быть больше 0!");
else
    Console.WriteLine($"Результат: ");

int i;                                      // вывод результата
for (i = 2; i < num; i = i+2)
    Console.Write( $"{i}  " );