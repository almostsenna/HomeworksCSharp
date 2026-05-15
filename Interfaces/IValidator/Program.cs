//using HomeworksCSharp.Interfaces.IValidator.Validation;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using Validation;

//namespace HomeworksCSharp.Interfaces.IValidator
//{
//    namespace Validation
//    {
//        class Program
//        {
//            static void Main(string[] args)
//            {
//                IValidator passwordValidator = new PasswordValidator();
//                IValidator emailValidator = new EmailValidator();

//                Console.WriteLine("Password validation:");
//                Console.WriteLine(passwordValidator.Validate("Test1234")); 
//                Console.WriteLine(passwordValidator.Validate("weak"));     

//                Console.WriteLine("\nEmail validation:");
//                Console.WriteLine(emailValidator.Validate("user@example.com")); 
//                Console.WriteLine(emailValidator.Validate("invalid-email"));    
//            }
//        }
//    }
//}
