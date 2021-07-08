using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn
{
    class Service
    {
        #region Print
        public static void Print(string output, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(output);
        }

        public static void PrintLine(string output, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(output);
        }

        public static void PrintCenter(string output)
        {
            int x = 0;
            if (output.Length / 2 < Console.WindowWidth / 2)
                x = Console.WindowWidth / 2 - (output.Length / 2);
            Console.SetCursorPosition(x, Console.CursorTop);
            Console.WriteLine(output);
        }

        #region PrintArray
        public static void PrintArray(string[] output)
        {
            for (int i = 0; i < output.Length; i++)
            {
                Console.WriteLine($" {i} : {output[i]} ");
            }
            Console.WriteLine("");
        }

        public static void PrintArray(char[] output)
        {
            for (int i = 0; i < output.Length; i++)
            {
                Console.WriteLine($" {i} : {output[i]} ");
            }
            Console.WriteLine("");
        }

        public static void PrintArray(int[] output)
        {
            for (int i = 0; i < output.Length; i++)
            {
                Console.WriteLine($" {i} : {output[i]} ");
            }
            Console.WriteLine("");
        }

        public static void PrintArray(double[] output)
        {
            for (int i = 0; i < output.Length; i++)
            {
                Console.WriteLine($" {i} : {output[i]} ");
            }
            Console.WriteLine("");
        }
        #endregion

        #endregion

        #region File
        public static void PrintToFile(string path, string filename, string output)
        {
            // Проверка наличия каталога для файла
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            // Запись в файл
            using (StreamWriter sw = new StreamWriter($"{path}{filename}.txt", true, System.Text.Encoding.Default))
            {
                sw.WriteLine(output);
            }
        }

        public static string ReadFromFile(string path, string filename)
        {
            // Чтение из файла
            using (StreamReader sr = new StreamReader(path + filename + ".txt"))
            {
                string output = sr.ReadToEnd();
                return output;
            }
        }

        #endregion

        #region array

        public static string[] Splitter(string input, char[] chars)
        {
            // Разбиение строки по массиву символов
            string[] output;
            input = input.Trim(' ');
            output = input.Split(chars, StringSplitOptions.RemoveEmptyEntries);
            return output;
        }

        public static string Uniter(string[] input)
        {
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                output = output + input[i];
            }
            return output;
        }
        public static string Uniter(char[] input)
        {
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                output = output + input[i];
            }
            return output;
        }

        // Это нужно только для перевода массива односимвольных строк в массив символов.
        // Для разбиения строки на массив есть String.ToCharArray(начало, конец)
        public static char[] StringToChar(string[] input)
        {
            char[] output = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Length <= 1)
                    output[i] = Char.Parse(input[i]);
                else
                    Console.WriteLine("Error : input string length > 1");
            }
            return output;
        }

        public static int FindChar(char[] input, char param)
        {
            int output = 0;
            for (int i = 0; i < input.Length; i++)
            {
                output = i;
                if (input[i] == param)
                    break;
            }
            if (output == input.Length - 1)
                output = 0;
            return output;
        }
        #endregion


        // Смена значений переменных местами
        public static void swap(ref int a, ref int b)
        {
            //ref - позволяет изменить значение входных переменных
            //после выполнения метода
            a = a + b;
            b = a - b;
            a = a - b;
        }

        public static bool Pass(string login, string password)
        {
            bool allow;
            if (login == "root" && password == "GeekBrains")
                allow = true;
            else
                allow = false;
            return allow;
        }

        public static void Pause()
        {
            Console.Write("Press enter to continue...");
            Console.ReadLine();
        }
    }
}
