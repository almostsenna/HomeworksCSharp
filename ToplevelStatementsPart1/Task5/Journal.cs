using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworksCSharp.ToplevelStatementsPart1.Task5
{
    using System;

    class Journal
    {
        private string name;
        private int foundedYear;
        private string description;
        private string phone;
        private string email;


        public void InputData()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Введіть назву журналу: ");
            name = Console.ReadLine();

            Console.Write("Введіть рік заснування: ");
            while (!int.TryParse(Console.ReadLine(), out foundedYear) || foundedYear <= 0)
            {
                Console.Write("Помилка! Введіть коректний рік: ");
            }

            Console.Write("Введіть опис журналу: ");
            description = Console.ReadLine();

            Console.Write("Введіть контактний телефон: ");
            phone = Console.ReadLine();

            Console.Write("Введіть контактний email: ");
            email = Console.ReadLine();
        }


        public void PrintData()
        {
            Console.WriteLine("\n--- Інформація про журнал ---");
            Console.WriteLine($"Назва: {name}");
            Console.WriteLine($"Рік заснування: {foundedYear}");
            Console.WriteLine($"Опис: {description}");
            Console.WriteLine($"Телефон: {phone}");
            Console.WriteLine($"Email: {email}");
        }


        public string GetName() => name;
        public void SetName(string value) => name = value;

        public int GetFoundedYear() => foundedYear;
        public void SetFoundedYear(int value) => foundedYear = value;

        public string GetDescription() => description;
        public void SetDescription(string value) => description = value;

        public string GetPhone() => phone;
        public void SetPhone(string value) => phone = value;

        public string GetEmail() => email;
        public void SetEmail(string value) => email = value;
    }
}
