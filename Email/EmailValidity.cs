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
            string pattern = @"^[a-zA-Z]{3}[a-zA-Z0-9]*@[a-zA-Z]+";
            string[] mail = { "abc@gmail","abcdf2","a@tvs" };
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
