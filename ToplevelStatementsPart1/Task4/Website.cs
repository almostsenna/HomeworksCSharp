//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace HomeworksCSharp.ToplevelStatementsPart1.Task4
//{
//    class Website
//    {
        
//        private string name;
//        private string path;
//        private string description;
//        private string ip;

    
//        public void InputData()
//        {
//            Console.OutputEncoding = Encoding.UTF8;
//            Console.Write("Введіть назву сайту: ");
//            name = Console.ReadLine();

//            Console.Write("Введіть шлях до сайту: ");
//            path = Console.ReadLine();

//            Console.Write("Введіть опис сайту: ");
//            description = Console.ReadLine();

//            Console.Write("Введіть IP-адресу сайту: ");
//            ip = Console.ReadLine();
//        }

       
//        public void PrintData()
//        {
//            Console.WriteLine("\n--- Інформація про сайт ---");
//            Console.WriteLine($"Назва: {name}");
//            Console.WriteLine($"Шлях: {path}");
//            Console.WriteLine($"Опис: {description}");
//            Console.WriteLine($"IP-адреса: {ip}");
//        }

      

//        public void SetName(string value)
//        {
//            name = value;
//        }

//        public string GetName()
//        {
//            return name;
//        }

//        public void SetPath(string value)
//        {
//            path = value;
//        }

//        public string GetPath()
//        {
//            return path;
//        }

//        public void SetDescription(string value)
//        {
//            description = value;
//        }

//        public string GetDescription()
//        {
//            return description;
//        }

//        public void SetIP(string value)
//        {
//            ip = value;
//        }

//        public string GetIP()
//        {
//            return ip;
//        }
//    }
//}
