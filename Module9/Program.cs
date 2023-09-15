using System;

namespace ExceptionPractice
{

    public class Program
    {

        public static void Main(string[] args)
        {
            /*
            Exception ex = new Exception("Новое Message");
            ex.Data.Add("Время создания исключения: ", DateTime.Now);
            ex.HelpLink = "www.leningrad.ru";
            */

            /*
             // Создайте консольное решение, в котором реализуйте конструкцию Try/Catch/Finally для обработки исключения ArgumentOutOfRangeException. 
             // В случае исключения отобразите в консоль сообщение об ошибке.
            try 
            {
                Console.WriteLine("Try");
                throw new ArgumentOutOfRangeException();
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Catch");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally");
            }
            */

            //Создайте консольное решение, в котором реализуйте конструкцию Try/Catch/Finally для обработки исключения RankException. 
            // В случае исключения отобразите в консоль тип исключения (через метод GetType()).
            try
            {
                Console.WriteLine("Try");
                throw new RankException();
            }
            catch (RankException ex)
            {
                Console.WriteLine("Catch");
                Console.WriteLine(ex.GetType());
            }
            finally
            {
                Console.WriteLine("Finally");
            }

        }
    }

    
}