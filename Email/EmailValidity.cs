using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Email
{
    class EmailValidity
    {
        public void EmailCheck()
        {
            string pattern = @"^[a-zA-Z]{3}([\- \+ _\.]*[a-zA-Z0-9]+)*@[a-zA-Z0-9]+\.[a-z]{2,3}(\.[a-zA-Z]{2,4}){0,1}$";
            string[] mail = { "abc@gmail.com","abcdf2.com","abc+h@tvs.com", "abc@1.com" , "abc-100@yahoo.com", "abc+100@gmail.com.in.in" };
            Regex regex = new Regex(pattern);
            for (int i = 0; i < mail.Length; i++)
            {
                if (regex.IsMatch(mail[i]))
                {
                    Console.WriteLine("{0}-->Valid",mail[i]);
                }
                else
                {
                    Console.WriteLine("{0}-->Invalid",mail[i]);
                }
            }
           
        }
    }
}
