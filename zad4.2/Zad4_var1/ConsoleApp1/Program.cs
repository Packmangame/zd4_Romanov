using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, a, b, k;
            string[] line = File.ReadAllText("input.txt").Split(' ');
            n=int.Parse(line[0]);
            a=int.Parse(line[1]);
            b=int.Parse(line[2]);
            k=int.Parse(line[3])-1;
            int ans = 0;
            StreamWriter sw = new StreamWriter("output.txt");

            if(n>k)
            {   
                ans = k * b + a;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(ans);
                Console.ResetColor();
                sw.WriteLine(ans);
                sw.Close();
            }

            Console.WriteLine("Press any buttons");
            Console.Read();
            Environment.Exit(0);
        }
    }
}
