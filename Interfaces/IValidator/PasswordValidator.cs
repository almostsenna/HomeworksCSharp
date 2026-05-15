//using System;
//using System.Collections.Generic;
//using System.Reflection;
//using System.Text;
//using System.Text.RegularExpressions;

//namespace HomeworksCSharp.Interfaces.IValidator
//{
    
//    namespace Validation
//    {
//        public class PasswordValidator : IValidator
//        {
//            public bool Validate(string input)
//            {
               
//                if (string.IsNullOrEmpty(input)) return false;

//                var hasUpperCase = Regex.IsMatch(input, "[A-Z]");
//                var hasDigit = Regex.IsMatch(input, "[0-9]");
//                var hasMinLength = input.Length >= 8;

//                return hasUpperCase && hasDigit && hasMinLength;
//            }
//        }
//    }

//}
