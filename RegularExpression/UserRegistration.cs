using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegularExpression
{
    public class UserRegistration
    {
        public int CheckName(string name)
        {
            string pattern = "^[A-Z][a-z]{2}[a-z]*$";
            Regex regex = new Regex(pattern);
            if(regex.IsMatch(name))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int EmailCheck(string mail)
        {
            string pattern = @"^[a-zA-Z]{3}([\- \+ _\.]*[a-zA-Z0-9]+)*@[a-zA-Z0-9]+\.[a-z]{2,3}(\.[a-zA-Z]{2,4}){0,1}$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(mail))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int MobileNumberCheck(string number)
        {
            string pattern = @"^[1-9]{2}\s[1-9][0-9]{9}$";
            Regex regex = new Regex(pattern);
            if(regex.IsMatch(number))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int  CheckPassword(string password)
        {
            string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?!.*[<>`])(?=[^.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\]*[.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\][^.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\]*$).{8,}$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(password))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
