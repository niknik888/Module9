using System;

// Создаем собственный тип исключения
public class MyCustomException : Exception
{
    public MyCustomException(string message) : base(message) { }
}

class Program
{
    static void Main()
    {
        try
        {
            // Генерируем разные виды исключений
            ThrowExceptions();
        }
        catch (MyCustomException ex)
        {
            Console.WriteLine("Поймано собственное исключение: " + ex.Message);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Поймано исключение деления на ноль: " + ex.Message);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Поймано исключение аргумента: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Поймано общее исключение: " + ex.Message);
        }

    }

    static void ThrowExceptions()
    {


        // Генерируем собственное исключение
        throw new MyCustomException("Это собственное исключение");

        // Генерируем исключение деления на ноль
        int zero = 0;
        int result = 10 / zero;

        // Генерируем исключение аргумента
        ValidateInput(null);

        // Генерируем общее исключение
        throw new Exception("Это общее исключение");
    }

    static void ValidateInput(string input)
    {
        if (input == null)
        {
            throw new ArgumentException("Недопустимый аргумент", nameof(input));
        }
    }
}
