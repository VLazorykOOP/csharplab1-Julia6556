//task 1
using System;

class Program
{
    static void Main(string[] args)
    {
        // Повідомлення для користувача, яке пояснює, що потрібно ввести два числа
        Console.WriteLine("Введіть два числа для обчислення середнього арифметичного їх кубів:");

        // Оголошення змінних для зберігання введених чисел
        double num1, num2;

        // Перевірка правильності введення першого числа
        Console.Write("Введіть перше число: ");
        while (!double.TryParse(Console.ReadLine(), out num1))
        {
            // Якщо введені дані не можуть бути перетворені в double, виводиться повідомлення про помилку
            Console.WriteLine("Некоректне введення. Будь ласка, спробуйте ще раз.");
            Console.Write("Введіть перше число: ");
        }

        // Перевірка правильності введення другого числа
        Console.Write("Введіть друге число: ");
        while (!double.TryParse(Console.ReadLine(), out num2))
        {
            // Якщо введені дані не можуть бути перетворені в double, виводиться повідомлення про помилку
            Console.WriteLine("Некоректне введення. Будь ласка, спробуйте ще раз.");
            Console.Write("Введіть друге число: ");
        }

        // Обчислення суми кубів
        double sumOfCubes = Math.Pow(num1, 3) + Math.Pow(num2, 3);

        // Ділення суми кубів на кількість чисел (у цьому випадку 2)
        double average = sumOfCubes / 2;

        // Виведення результату разом з введеними користувачем числами
        Console.WriteLine($"Середнє арифметичне кубів чисел {num1} і {num2} дорівнює {average}");

        // Затримка консолі перед закриттям, щоб користувач мав час переглянути результат
        Console.WriteLine("Натисніть будь-яку клавішу для завершення.");
        Console.ReadKey();
    }
}



//task 2

using System;

class MainClass
{
    public static void Main(string[] args)
    {
        // Просимо користувача ввести значення для M
        Console.WriteLine("Введіть ціле число M:");
        int m;

        // Перевіряємо, чи введено коректне ціле число
        while (!int.TryParse(Console.ReadLine(), out m))
        {
            Console.WriteLine("Введено некоректне значення. Спробуйте ще раз:");
        }

        // Просимо користувача ввести значення для N
        Console.WriteLine("Введіть ціле число N:");
        int n;

        // Перевіряємо, чи введено коректне ціле число, яке не дорівнює 0
        while (!int.TryParse(Console.ReadLine(), out n) || n == 0)
        {
            Console.WriteLine("Введено некоректне значення або 0. Спробуйте ще раз:");
        }

        // Перевіряємо, чи M ділиться націло на N
        if (m % n == 0)
        {
            // Якщо так, виводимо частку від ділення
            Console.WriteLine($"Частка від ділення M на N: {m / n}");
        }
        else
        {
            // Якщо ні, виводимо повідомлення про недільність націло
            Console.WriteLine("M на N націло не ділиться");
        }
    }
}


//task 3
using System;

class Program
{
    static void Main()
    {
        // Введення координат точки з клавіатури
        Console.Write("Введіть координату x: ");
        if (!double.TryParse(Console.ReadLine(), out double x))
        {
            Console.WriteLine("Некоректне введення для x. Будь ласка, введіть число.");
            return;
        }

        Console.Write("Введіть координату y: ");
        if (!double.TryParse(Console.ReadLine(), out double y))
        {
            Console.WriteLine("Некоректне введення для y. Будь ласка, введіть число.");
            return;
        }

        // Перевірка положення точки відносно заштрихованої області
        var result = GetPointPosition(x, y);

        // Виведення результату
        Console.WriteLine(result);
    }

    // Метод для визначення положення точки відносно заштрихованої області
    static string GetPointPosition(double x, double y)
    {
        // Задані межі заштрихованої області
        double minX = 0;
        double maxX = 0;
        double minY = -8;
        double maxY = 8;

        // Перевірка положення точки
        if (x < minX || x > maxX || y < minY || y > maxY)
        {
            return "Ні"; // Точка поза заштрихованою областю
        }
        else if ((x == minX || x == maxX) && (y >= minY && y <= maxY))
        {
            return "На межі"; // Точка на межі заштрихованої області
        }
        else if (x > minX)
        {
            double distanceToCenter = Math.Sqrt(x * x + y * y);
            if (distanceToCenter <= 8)
            {
                return "Так"; // Точка всередині заштрихованої області
            }
        }

        return "Ні"; // Точка поза заштрихованою областю
    }
}


//task 4
using System;

class Program
{
    static void Main()
    {
        int cardNumber;

        // Введення номера карти з клавіатури з перевіркою на коректність введення
        Console.Write("Введіть номер карти (6-14): ");
        while (!int.TryParse(Console.ReadLine(), out cardNumber) || cardNumber < 6 || cardNumber > 14)
        {
            Console.WriteLine("Некоректне введення. Номер карти повинен бути в межах від 6 до 14.");
            Console.Write("Спробуйте ще раз: ");
        }

        // Визначення назви карти
        string cardName = DetermineCardName(cardNumber);

        // Виведення результату
        Console.WriteLine($"Назва карти для номера {cardNumber}: {cardName}");

        Console.ReadLine();
    }

    // Функція для визначення назви карти
    static string DetermineCardName(int cardNumber)
    {
        switch (cardNumber)
        {
            case 14:
                return "Туз";
            case 13:
                return "Король";
            case 12:
                return "Дама";
            case 11:
                return "Валет";
            case 10:
                return "Десятка";
            case 9:
                return "Дев'ятка";
            case 8:
                return "Вісімка";
            case 7:
                return "Сімка";
            case 6:
                return "Шістка";
            default:
                return "Невідома карта";
        }
    }
}

//task 5
using System;

class Program
{
    static void Main(string[] args)
    {
        int dividend; // змінна для діленця
        int divisor; // змінна для дільника
        int quotient; // змінна для частки

        // Запит користувача на введення діленця
        Console.WriteLine("Введіть ділене число:");
        string input = Console.ReadLine();

        // Перевірка, чи введено коректне ціле число
        while (!int.TryParse(input, out dividend))
        {
            Console.WriteLine("Некоректне введення. Введіть ціле число:");
            input = Console.ReadLine();
        }

        // Запит користувача на введення дільника
        Console.WriteLine("Введіть дільник:");
        input = Console.ReadLine();

        // Перевірка, чи введено коректне ціле число
        while (!int.TryParse(input, out divisor) || divisor == 0)
        {
            if (divisor == 0)
            {
                Console.WriteLine("Дільник не може бути нулем. Введіть інше число:");
            }
            else
            {
                Console.WriteLine("Некоректне введення. Введіть ціле число:");
            }
            input = Console.ReadLine();
        }

        // Обчислення частки і виведення результату
        quotient = dividend / divisor;
        Console.WriteLine($"Частка {dividend} на {divisor} дорівнює {quotient}");
    }
}
//task 6
using System;

class Program
{
    static void Main(string[] args)
    {
        double a; // змінна для числа a
        double b; // змінна для числа b
        double result; // змінна для збереження результату виразу

        // Запит користувача на введення числа a
        Console.WriteLine("Введіть число a:");
        string inputA = Console.ReadLine();

        // Перевірка, чи введено коректне дійсне число
        while (!double.TryParse(inputA, out a))
        {
            Console.WriteLine("Некоректне введення. Введіть дійсне число для a:");
            inputA = Console.ReadLine();
        }

        // Запит користувача на введення числа b
        Console.WriteLine("Введіть число b:");
        string inputB = Console.ReadLine();

        // Перевірка, чи введено коректне дійсне число
        while (!double.TryParse(inputB, out b))
        {
            Console.WriteLine("Некоректне введення. Введіть дійсне число для b:");
            inputB = Console.ReadLine();
        }

        // Обчислення виразу
        result = ((a * b + (a - b) * (a + b) - 1) / (Math.Pow(a, 2) + Math.Pow(b, 2))) - 5;

        // Виведення результату
        Console.WriteLine($"Результат виразу: {result}");
    }
}





