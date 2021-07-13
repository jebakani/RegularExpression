using System;
using PinCode;

namespace RegularExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regular Expression");
            PinCodeCheck pincode = new PinCodeCheck();
            string[] pinCodes = { "400088", "A400088", "400088B" };
            for (int i = 0; i < pinCodes.Length; i++)
            {
                pincode.CheckPin(pinCodes[i]);
            }
        }
    }
}
