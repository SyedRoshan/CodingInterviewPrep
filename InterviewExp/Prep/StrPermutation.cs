using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prep
{
    public class StrPermutation
    {
        public static void Main()
        {
            string str = "abc";
            int n = str.Length;
            permute(str, 0, n - 1);


            Console.WriteLine("press any key...");
            Console.Read();
        }

        public static void permute(string s, int left, int right)
        {
            if (left == right)
            {
                Console.WriteLine(s);
            }
            else
            {
                for (int i = left; i <= right; i++)
                {
                    s = swap(s, left, i);
                    permute(s, left + 1, right);
                    s = swap(s, left, i);
                }
            }
        }

        public static String swap(String s, int i, int j)
        {
            char[] ch = s.ToCharArray();
            char temp;

            temp = ch[j];
            ch[j] = ch[i];
            ch[i] = temp;

            return new string(ch);
        }
    }
}
