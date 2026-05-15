//using HomeworksCSharp.Interfaces.IValidator.Validation;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Text.RegularExpressions;

//namespace Validation
//{
//    public class EmailValidator : IValidator
//    {
//        public bool Validate(string input)
//        {
//            if (string.IsNullOrEmpty(input)) return false;

//            // email pattern
//            var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
//            return Regex.IsMatch(input, emailPattern);
//        }
//    }
//}

