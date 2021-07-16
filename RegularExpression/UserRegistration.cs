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
        public string CheckName(string name)
        {
            string pattern = "^[A-Z][a-z]{2}[a-z]*$";
            Regex regex = new Regex(pattern);
            try
            {
                if (name == null)
                {
                    throw new CustomeException(CustomeException.ExceptionType.NULL_EXCEPTION, "Name should not be null");
                }
                if (name == "")
                {
                    throw new CustomeException(CustomeException.ExceptionType.EMPTY_EXCEPTION, "Name should not be empty");
                }
                if (regex.IsMatch(name))
                {
                    return "1";
                }
                else
                {
                    return "0";
                }
            }
            catch(NullReferenceException e)
            {
                return (e.Message);
            }
        }
        public string EmailCheck(string mail)
        {
            string pattern = @"^[a-zA-Z]{3}([\- \+ _\.]*[a-zA-Z0-9]+)*@[a-zA-Z0-9]+\.[a-z]{2,3}(\.[a-zA-Z]{2,4}){0,1}$";
            Regex regex = new Regex(pattern);
            try
            {
                if (regex.IsMatch(mail))
                {
                    return "1";
                }
                else
                {
                    return "0";
                }
            }
            catch(Exception e)
            {
                return "Email should not be null";
            }
        }
        public string MobileNumberCheck(string number)
        {
            string pattern = @"^[1-9]{2}\s[1-9][0-9]{9}$";
            Regex regex = new Regex(pattern);
            try
            {
                if (number == null)
                {
                    throw new CustomeException(CustomeException.ExceptionType.NULL_EXCEPTION, "Number should not be null");
                }
                if (number == "")
                {
                    throw new CustomeException(CustomeException.ExceptionType.EMPTY_EXCEPTION, "Number should not be empty");
                }
                if (regex.IsMatch(number))
                {
                    return "1";
                }
                else
                {
                    return "0";
                }
            }catch (Exception e)
            {
                return (e.Message);
            }
        }
        public string CheckPassword(string password)
        {
            string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?!.*[<>`])(?=[^.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\]*[.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\][^.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\]*$).{8,}$";
            Regex regex = new Regex(pattern);
            try
            {
                if (password == null)
                {
                    throw new CustomeException(CustomeException.ExceptionType.NULL_EXCEPTION, "Password should not be null");
                }
                if (password == "")
                {
                    throw new CustomeException(CustomeException.ExceptionType.EMPTY_EXCEPTION, "Password should not be empty");
                }
                if (regex.IsMatch(password))
                {
                    return "1";
                }
                else
                {
                    return "0";
                }
            }
            catch(Exception e)
            {
                return (e.Message);
            }
        }
    }
}
