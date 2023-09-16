// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.Design;

Console.WriteLine("1. сложение");
Console.WriteLine("2. вычитание");
Console.WriteLine("3. умножение");
Console.WriteLine("4. деление");
Console.WriteLine("5. возведение в степень");
Console.WriteLine("6. квадратный корень");
Console.WriteLine("7. 1 процент от числа");
Console.WriteLine("8. факториал");
Console.WriteLine("9. выйти из программы");
string opt;
int nopt = 0;
int a = 0, b = 0, c = 0;
while (nopt != 9)
{
    Console.WriteLine("Выберите опцию:");
    opt = Console.ReadLine();
    nopt = Convert.ToInt32(opt);
    switch (nopt)
    {
        case 1:
            Console.WriteLine("Введите первое число:");
            string a1 = Console.ReadLine();
            a = Convert.ToInt32(a1);
            Console.WriteLine("Введите второе число:");
            string b1 = Console.ReadLine();
            b = Convert.ToInt32(b1);
            c = a + b;
            Console.WriteLine("Сумма:" + c);
            break;
        case 2:
            Console.WriteLine("Введите первое число:");
            string a2 = Console.ReadLine();
            a = Convert.ToInt32(a2);
            Console.WriteLine("Введите второе число:");
            string b2 = Console.ReadLine();
            b = Convert.ToInt32(b2);
            c = a - b;
            Console.WriteLine("Разность:" + c);
            break;
        case 3:
            Console.WriteLine("Введите первое число:");
            string a3 = Console.ReadLine();
            a = Convert.ToInt32(a3);
            Console.WriteLine("Введите второе число:");
            string b3 = Console.ReadLine();
            b = Convert.ToInt32(b3);
            c = a * b;
            Console.WriteLine("Произведение:" + c);
            break;
        case 4:
            Console.WriteLine("Введите первое число:");
            string a4 = Console.ReadLine();
            a = Convert.ToInt32(a4);
            Console.WriteLine("Введите второе число:");
            string b4 = Console.ReadLine();
            b = Convert.ToInt32(b4);
            if (b == 0)
            {
                Console.WriteLine("Ошибка!");
                break;
            }
            c = a / b;
            Console.WriteLine("Частное:" + c);
            break;
        case 5:
            Console.WriteLine("Введите число:");
            string a5 = Console.ReadLine();
            a = Convert.ToInt32(a5);
            Console.WriteLine("Введите степень:");
            string b5 = Console.ReadLine();
            b = Convert.ToInt32(b5);
            double c5 = Math.Pow(a, b);
            Console.WriteLine("Результат:" + c5);
            break;
        case 6:
            Console.WriteLine("Введите число:");
            string a6 = Console.ReadLine();
            a = Convert.ToInt32(a6);
            if (a < 0)
            {
                Console.WriteLine("Ошибка!");
                break;
            }
            double c6 = Math.Pow(a, 0.5);
            Console.WriteLine("Результат:" + c6);
            break;
        case 7:
            Console.WriteLine("Введите число:");
            string a7 = Console.ReadLine();
            float af = Convert.ToInt32(a7);
            if (af == 0)
            {
                Console.WriteLine("Ошибка!");
                break;
            }
            float c7 = af / 100;
            Console.WriteLine("Результат:" + c7);
            break;
        case 8:
            Console.WriteLine("Введите число:");
            string a8 = Console.ReadLine();
            a = Convert.ToInt32(a8);
            if (a < 0)
            {
                Console.WriteLine("Ошибка!");
                break;
            }
            c = 1;
            for (int i = 1; i <= a; i++)
            {
                c = c * i;
            }
            Console.WriteLine("Результат:" + c);
            break;
    }
}