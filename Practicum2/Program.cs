using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите фамилии пятерых человек:");

        List<string> surnames = new List<string>();
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Человек {i + 1}: ");
            string surname = Console.ReadLine();
            surnames.Add(surname);
        }

        Sorter sorter = new Sorter(surnames);

        sorter.SortCompleted += (sender, e) =>
        {
            Console.WriteLine("Сортировка завершена. Результат:");
            foreach (var surname in sorter.SortedSurnames)
            {
                Console.WriteLine(surname);
            }
        };

        int choice;
        while (true)
        {
            Console.WriteLine("Выберите порядок сортировки: ");
            Console.WriteLine("1. А-Я");
            Console.WriteLine("2. Я-А");

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                if (choice == 1)
                {
                    sorter.SortAscending();
                    break;
                }
                else if (choice == 2)
                {
                    sorter.SortDescending();
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка: Выберите 1 или 2.");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: Введите число 1 или 2.");
            }
        }
    }
}

class Sorter
{
    private List<string> _surnames;

    public List<string> SortedSurnames { get; private set; }

    public event EventHandler SortCompleted;

    public Sorter(List<string> surnames)
    {
        _surnames = surnames;
    }

    public void SortAscending()
    {
        SortedSurnames = new List<string>(_surnames);
        SortedSurnames.Sort();
        OnSortCompleted();
    }

    public void SortDescending()
    {
        SortedSurnames = new List<string>(_surnames);
        SortedSurnames.Sort();
        SortedSurnames.Reverse();
        OnSortCompleted();
    }

    protected virtual void OnSortCompleted()
    {
        SortCompleted?.Invoke(this, EventArgs.Empty);
    }
}
