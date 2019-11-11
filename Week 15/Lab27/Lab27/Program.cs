using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab27
{
    public class Program
    {
        public static string TitleCase(String data)
        {
            string ret = "";
            if (data != "")
            {
                string[] words = data.ToLower().Split();

                foreach (var word in words)
                {
                    ret += word[0].ToString().ToUpper() + word.Substring(1) + " ";
                }
                ret = ret.Trim();
            }
            else ret = data;
            return ret;
        }
        static void Main()
        {

            Console.WriteLine(TitleCase(Console.ReadLine()));
            Console.ReadLine();
        }
    }
}
