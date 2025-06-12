using System;
using System.Text;

namespace _1934_LeasrCommonMultiple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int32 t = Int32.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            for(Int32 i = 0; i < t; i++)
            {
                String[] str = Console.ReadLine().Split();
                Int32 a = Int32.Parse(str[0]);
                Int32 b = Int32.Parse(str[1]);
                Int32 lm;

                Int32 oa = a;
                Int32 ob = b;
                while (true)
                {
                    if (a % b == 0)
                    {
                        lm = b;
                        break;
                    }

                    Int32 tmp = a;
                    a = b;
                    b = tmp % b;
                }

                lm = (oa * ob) / lm;

                sb.AppendLine(lm.ToString());
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
