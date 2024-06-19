using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace transportation_system.Global
{
    internal class clsGlobal
    {
        public static bool ValidateInteger(string Number)
        {
            var pattern = "^[0-9].$";
            var regex = new Regex(pattern);

            return regex.IsMatch(Number);
        }
        public static bool ValidateFloat(string Number)
        {
            var pattern = @"^[0-9]*(?:\.[0-9]*)?$";
            var regex = new Regex(pattern);
            return regex.IsMatch(Number);
        }
        public static bool isNumber(string Number)
        {
            return ValidateFloat(Number) || ValidateInteger(Number);
        }
    }
}
