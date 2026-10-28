//Задание 1. Деление чисел
//Запроси у пользователя два целых числа.
//Преобразуй введённые строки в числа.
//Помести преобразование и деление в блок try.
//Добавь catch, который обрабатывает FormatException, если пользователь ввёл не число.
//Добавь отдельный catch для DivideByZeroException.
//Выведи результат деления, если ошибок не возникло.
//Проверь программу на корректных данных, вводе букв и делении на ноль.
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите два целых числа для деления:");
//        try
//        {
//            int num1 = int.Parse(Console.ReadLine());
//            int num2 = int.Parse(Console.ReadLine());
//            int result = num1 / num2;
//            Console.WriteLine($"Результат деления: {result}");

//        }
//        catch(FormatException)
//        {
//            Console.WriteLine("Нужно ввести числа.");
//        }
//        catch(DivideByZeroException)
//        {
//            Console.WriteLine("Деление на ноль невозможно.");
//        }

//    }
//}

//Задание 2. Безопасное преобразование
//Запроси у пользователя его возраст.
//Попробуй преобразовать введённую строку в int внутри try.
//Если возник FormatException, выведи сообщение о неправильном формате.
//Если возраст меньше нуля, самостоятельно выброси ArgumentOutOfRangeException с помощью throw.
//Добавь отдельный catch для этого исключения.
//Если ввод корректен, выведи возраст.

//Console.WriteLine("Введите ваш возраст:");
//string input=Console.ReadLine();
//try
//{
//    int age = int.Parse(input);
//    if (age < 0)
//    {
//        throw new ArgumentOutOfRangeException("Возраст не может быть меньше нуля.");
//    }
//    Console.WriteLine($"Ваш возраст: {age}");
//}
//catch (FormatException)
//{
//    Console.WriteLine("Неправильный формат ввода. Пожалуйста, введите число.");

//}
//catch (ArgumentOutOfRangeException ex)
//{
//    Console.WriteLine(ex.Message);
//}



//Задание 3. Зачем нужен finally?
//Создай метод, который принимает строку и пытается преобразовать её в число.
//Добавь блок try, в котором выполняется преобразование.
//Добавь catch, который сообщает об ошибке преобразования.
//Добавь finally, который выводит сообщение Operation completed.
//Вызови метод с корректной строкой.
//Вызови метод с некорректной строкой.
//Сравни результаты и объясни, когда выполняется finally.
//class Program
//{
//    static void TryParse(string input)
//    {
//        try
//        {
//            int number = int.Parse(input);
//            Console.WriteLine($"Преобразованное число: {number}");
//        }
//        catch (FormatException)
//        {
//            Console.WriteLine("Ошибка преобразования. Введена некорректная строка.");
//        }
//        finally
//        {
//            Console.WriteLine("Operation completed.");
//        }
//    }
//    static void Main()
//    {
//        TryParse("123");
//        Console.WriteLine();
//        TryParse("abc");
//    }
//}


//Задание 4. Проверка возраста
//Создай собственное исключение InvalidAgeException, наследующееся от Exception.
//Добавь конструктор, принимающий сообщение об ошибке.
//Создай метод CheckAge(int age).
//Если возраст меньше 18 лет, выброси InvalidAgeException с сообщением Age must be at least 18.
//В Main вызови CheckAge внутри блока try.
//Обработай InvalidAgeException через catch и выведи сообщение ошибки.
//Проверь программу с возрастом меньше 18 и возрастом 18 или больше.

using System;
class Program
{
    static void Main()
    {
        try
        {
            AgeValidator.CheckAge(15);
        }
        catch (InvalidAgeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        try
        {
            AgeValidator.CheckAge(20);
        }
        catch (InvalidAgeException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}