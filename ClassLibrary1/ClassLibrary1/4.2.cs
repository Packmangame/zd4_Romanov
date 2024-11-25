using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.CodeDom;

namespace ClassLibrary1
{
    //4.2
    public class Class1
    {   //существование файла
        public bool Method1(string filename)
        {
            return File.Exists($@"{filename}");
        }
        
        //проверка формата входных данных
        public bool Method2(string line)
        {
            return Regex.IsMatch(line, @"^\d\s\d\s\d\s\d$");
        } 
        
        //проверка типа входных данных
        public bool Method3(string input)
        {
            string[] line=input.Split(' ');
            try
            {
                int i = int.Parse(line[0]);
                int b = int.Parse(line[1]);
                int c = int.Parse(line[2]);
                int d = int.Parse(line[3]);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        //проверка что выводится только 1 символ и не пустая строка
        public bool Method4(string input)
        {
             return !string.IsNullOrEmpty(input) && input.Length == 1 && char.IsDigit(input[0]);
        }
        
    }   
}
