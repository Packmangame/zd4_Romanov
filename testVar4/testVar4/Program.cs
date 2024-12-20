﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace testVar4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("output.txt");
            string line = File.ReadAllText("input.txt");
            if (line.Contains('?') == false)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Error");
                Console.ResetColor();
                sw.WriteLine("Error");
                sw.Close();
            }
            else
            {
                line = line.Remove(0, line.IndexOf('?') + 1);
                
                string[] lineArray = line.Split('&');
                string[] lineArray1 = lineArray[0].Split('=');
                string[] lineArray2 = lineArray[1].Split('=');
                string[] lineArray3 = lineArray[2].Split('=');

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(lineArray1[0] + ":" + lineArray1[1] + "\n" + lineArray2[0] + ":" + lineArray2[1] + "\n" + lineArray3[0] + ":" + lineArray3[1]);
                Console.ResetColor();
                sw.WriteLine(lineArray1[0] + ":" + lineArray1[1] + "\n" + lineArray2[0] + ":" + lineArray2[1] + "\n" + lineArray3[0] + ":" + lineArray3[1]);
                sw.Close();
            }

            Console.WriteLine("Press any buttons");
            Console.ReadLine();
            Environment.Exit(0);

        }
    }
}
