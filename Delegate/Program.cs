using System;

/*
class Program
{
    public delegate void MyDelegate(int a, int b);
    public static void Main(string[] args)
    {
        MyDelegate myDelegate = sub;
        myDelegate += sum;
        myDelegate -= sum;
        myDelegate.Invoke(10, 5);
    }

    static void sub(int a, int b)
    {
        Console.WriteLine(a - b);
    }
    static void sum(int a, int b)
    {
        Console.WriteLine(a + b);
    }
}

*/

/*
class Program
{
    
    public static void Main(string[] args)
    {
        Action showMessageDelegate = ShowMessage;
        showMessageDelegate.Invoke();

        Func <int, int,int, int> sumDelegate = Sum;
        int result = sumDelegate.Invoke(1, 30, 120);
        Console.WriteLine(result);

        Predicate<string> checkLengthDelegate = CheckLength;
        bool status = checkLengthDelegate.Invoke("skill_factory");
        Console.WriteLine(status);
    }

    

    static void ShowMessage()
    {
        Console.WriteLine("Hello World!");
    }

    static int Sum(int a, int b, int c)
    {
        return a + b + c;
    }

    static bool CheckLength(string _row)
    {
        if (_row.Length > 3) return true;
        return false;
    }

}
*/

/*
// 9.3.12 Реализуйте в данном решении анонимный метод, не сломав логику приложения.
class Program
    {
        delegate void ShowMessageDelegate(string _message);
        static void Main(string[] args)
        {
            ShowMessageDelegate showMessageDelegate = delegate (string _message)
            {
                Console.WriteLine(_message);
            };
            showMessageDelegate.Invoke("Hello World!");
            Console.Read();
        }


    }
*/

// 9.3.13 Существует консольное решение, которое выводит случайное целое число в диапазоне от 0 до 100 и отображает результат в консольное сообщение
/*
class Program
    {
        delegate int RandomNumberDelegate();
        static void Main(string[] args)
        {
            RandomNumberDelegate randomNumberDelegate = delegate ()
            {
                return new Random().Next(0, 100);
            };

            int result = randomNumberDelegate.Invoke();

            Console.WriteLine(result);
            Console.Read();
        }


    }
*/

// 9.3.14 Реализуйте лямбда-оператор.
/*
class Program
{
    delegate void ShowMessageDelegate(string _message);
    static void Main(string[] args)
    {
        ShowMessageDelegate showMessageDelegate = (string _message) => { Console.WriteLine(_message); };

        showMessageDelegate.Invoke("Hello World!");
        Console.Read();
    }


}
*/


// 9.3.15 Реализуйте лямбда-оператор.
class Program
{
    delegate int RandomNumberDelegate();
    static void Main(string[] args)
    {
        RandomNumberDelegate randomNumberDelegate = () =>
        {
            return new Random().Next(0, 100);
        };

        int result = randomNumberDelegate.Invoke();

        Console.WriteLine(result);
        Console.Read();
    }


}