using System;

string value;
string op;
bool end = false;
do
{
    Console.Write("выбирите операцию 1-сложение 2-вычитание 3-умножение 4-деление 5-степень 6-квадратный корень 7-1% от числа 8-факториал 9-выход:");
    op = Console.ReadLine();
    
    int result;
    Console.Write("введите первое число:");
    int num1 = Convert.ToInt32(Console.ReadLine());
    

    switch (op)
    {
        case "1":
            Console.Write("введите второе число:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            result = num1 + num2;
            Console.WriteLine("сложение:" + result);
            break;
        case "2":
            Console.Write("введите второе число:");
            num2 = Convert.ToInt32(Console.ReadLine());
            result = num1 - num2;
            Console.WriteLine("вычитание:" + result);
            break;
        case "3":
            Console.Write("введите второе число:");
             num2 = Convert.ToInt32(Console.ReadLine());
            result = num1 * num2;
            Console.WriteLine("умножение:" + result);
            break;
        case "4":
            Console.Write("введите второе число:");
             num2 = Convert.ToInt32(Console.ReadLine());
            if (num2 == 0) { Console.WriteLine("делить на 0 нельзя"); }
            else
            {
                result = num1 / num2;
                Console.WriteLine("деление:" + result);
            }
            break;
        case "5":
            Console.Write("введите второе число:");
             num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("степень =" + (Math.Pow(num1, num2)));
            break;
        case "6":
            Console.WriteLine("квадратный корень равен "+(Math.Sqrt(num1)));
            break;
        case "7":
            result = num1 / 100;
            Console.WriteLine("1% от числа " + num1 + "=" + result);
            break;
        case "8":

            long factorial = (1);
            if (factorial == 0)
            {
                Console.WriteLine("Факториал 0 = 1");
            }
            else
                for (int i = 1; i <= num1; i++)
                {
                    factorial *= i;
                }
            Console.WriteLine($"Факториал {num1} " + (factorial));

            break;
        case "9":
            end = true;
            break;
        default:
            Console.WriteLine("неверная операция");
            break;
        
    }
    
}
while (!end);