using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegularExpression
{
    class UserRegistration
    {
        public void CheckName(string name)
        {
            string pattern = "^[A-Z][a-z]{2}[a-z]*$";
            Regex regex = new Regex(pattern);
            if(regex.IsMatch(name))
            {
                Console.WriteLine("{0} is Valid name",name);
            }
            else
            {
                Console.WriteLine("{0} is Invalid",name);
            }
        }
        public void EmailCheck(string mail)
        {
            string pattern = @"^[a-zA-Z]{3}([\- \+ _\.]*[a-zA-Z0-9]+)*@[a-zA-Z0-9]+\.[a-z]{2,3}(\.[a-zA-Z]{2,4}){0,1}$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(mail))
            {
                  Console.WriteLine("{0}-->Valid", mail);
            }
            else
            {
                  Console.WriteLine("{0}-->Invalid", mail);
            }
        }
        public void MobileNumberCheck(string number)
        {
            string pattern = @"^[1-9]{2}\s[1-9][0-9]{9}$";
            Regex regex = new Regex(pattern);
            if(regex.IsMatch(number))
            {
                Console.WriteLine("{0} is valid",number);
            }
            else
            {
                Console.WriteLine("{0} is invalid",number);
            }
        }
        public void CheckPassword(string password)
        {
            string pattern = "^(.*[A-Z].*)(.*[a-z].*)[A-za-z0-9]{6,}$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(password))
            {
                Console.WriteLine("{0} is valid password", password);
            }
            else
            {
                Console.WriteLine("{0} is invalid password", password);
            }
        }
    }
}
