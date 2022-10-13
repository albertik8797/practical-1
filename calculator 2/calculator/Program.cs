namespace GuessNumber
{
    class Program
    {
        static void Ugad()
        {
            int myNum;
            Console.Title = " Угадай число ";
            Random rand = new Random();
            string temp;
            int secret = rand.Next(100);
            Console.WriteLine("Я загодал число от 0 до 100 Попробуйте его отгадать.");
            while (true)
            {
                Console.Write("Введите число: ");
                temp = Console.ReadLine();
                if (!int.TryParse(temp, out int myNam))
                {
                    continue;
                }
                if (myNam == secret)
                {
                    Console.WriteLine("Угадали.");
                    break;
                }
                else
                {
                    if (myNam > secret)
                    {
                        Console.WriteLine("Моe число меньше твоего.");
                    }
                    else
                    {
                        Console.WriteLine("Моe число больше твоего.");
                    }
                }
            }
        }
        static void tabl()
        {
            int[,] myltiplytable = new int[10, 10];
            for (int i = 1; i < 10; i++)
                for (int j = 1; j < 10; j++)
                    myltiplytable[i, j] = i * j;
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine();
                for (int j = 1; j < 10; j++)
                    Console.Write("{0,3}", myltiplytable[i, j] + "\t");
            }
        }
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\nВыбери программу:\n1:Угадай число\n2:Таблица умножения\n3:Выйти");
                string oper;
                oper = Console.ReadLine();
                if (!int.TryParse(oper, out int myNam))
                {
                    Console.WriteLine("Введи число");
                }
                if (myNam == 1)
                {
                    Ugad();
                }
                else if (myNam == 2)
                {
                    tabl();
                }
                else if (myNam == 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Выбери приложение из списка");
                }
            }
        }
    }
}