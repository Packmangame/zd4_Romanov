using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Policy;
using System.Text.RegularExpressions;

namespace ClassLibrary1
{
    public class test
    {
        //существование файлав
        public bool Method1(string filename)
        {
            return File.Exists($@"{filename}");
        }

        //есть ли параметры в URL ссылке
        public bool Method2(string URL)
        {
            string line = URL;
            return line.Contains("?");
        }

        //количество строк в файле
        public bool Method3(string filename)
        {
            StreamReader reader= new StreamReader($@"{filename}.txt");
            // Читаем первую строку
            string line = reader.ReadLine();
            // Если первая строка не null, читаем следующую
            if (line != null)
            {
                // Проверяем, есть ли еще строки
                if (reader.ReadLine() == null)
                {
                    return true; // Файл содержит только одну строку
                }
            }
            return false;
        }

        //количество символов в строке
        public bool Method4(string line)
        {
           if (line.Length < 10000 && line.Length > 0)
            {
                return true;
            }
            return false;
        }

        //проверка выходных данных
        public bool Method5(string input)
        {
            // Проверяем наличие символа ':' и что перед ним и после него есть непробельные символы
            int colonIndex = input.IndexOf(':');

            if (colonIndex > 0 && colonIndex < input.Length - 1)
            {
                // Проверяем, что перед ':' есть непробельный символ
                if (char.IsWhiteSpace(input[colonIndex - 1]))
                {
                    // Проверяем, что после ':' есть непробельный символ
                    if (char.IsWhiteSpace(input[colonIndex + 1]))
                    {
                        return true;
                    }
                }
            }

            return false;

        }

        //тест на кол-во параметров
        public bool Method6(string url)
        {
            if (url.Contains("?"))
            {
                // Извлекаем часть с параметрами
                string parametersPart = url.Split('?')[1];

                // Разбиваем параметры по символу '&'
                string[] parameters = parametersPart.Split('&');

                
                return parameters.Length<=3&&parameters.Length>0;
            }
            return false;

        }

        

        //создание правильного шаблона URL адреса
        private static readonly Regex UrlRegex = new Regex(
        @"^(http|https)://[^\s/$.?#].[^\s]*$",
        RegexOptions.IgnoreCase);


        //проверка URL адреса на правильность ввода
        public bool Method7(string url)
        {
           return UrlRegex.IsMatch(url);
        }

        public bool Method8(string url)
        {
            int questionMarkIndex = url.IndexOf('?');

            // Если '?' не найден, значит параметров нет
            if (questionMarkIndex == -1)
            {
                return false;
            }

            // Извлекаем часть строки после '?'
            string parametersPart = url.Substring(questionMarkIndex + 1);

            // Проверяем, есть ли хотя бы один параметр
            // Параметры разделяются символом '&'
            return parametersPart.Contains("="); // Проверяем наличие '=' для определения параметров
        }
    }
 
}
