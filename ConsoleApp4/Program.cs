//your mum lol
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ifthisdoesnotworkillkillu
{
    class Gaetest2
    {
        static string Yourmumgay(int length)
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(validChars[rnd.Next(validChars.Length)]);
            }
            return res.ToString();
        }

        static void Main(string[] args)
        {
           
            int length = 10;

            string pass = Yourmumgay(length);
            Console.Write(pass);
        }
    }
}
