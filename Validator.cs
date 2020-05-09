using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Graphics_Package
{
    abstract class Validator
    {
        private static readonly Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
        public static bool validate(string x1, string y1, string x2, string y2)
        {
            if (regex.IsMatch(x1) && regex.IsMatch(y1) && regex.IsMatch(x2) && regex.IsMatch(y2))
                return true;
            return false;
        }

    }
}
