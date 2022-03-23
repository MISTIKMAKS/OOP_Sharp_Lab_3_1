using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_1
{
    class Program
    {
        static int CountB(string str)
        {
            if (str.Length < 1)
            {
                return 0;
            }
            int b = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'B')
                {
                    b++;
                }
            }
            return b;
        }
        static int CountA(string str)
        {
            if (str.Length < 1)
            {
                return 0;
            }
            int a = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'A')
                {
                    a++;
                }
            }
            return a;
        }
        static int CountS(string str)
        {
            if (str.Length < 1)
            {
                return 0;
            }
            int s = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'S')
                {
                    s++;
                }
            }
            return s;
        }
        static int CountI(string str)
        {
            if (str.Length < 1)
            {
                return 0;
            }
            int ia = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'I')
                {
                    ia++;
                }
            }
            return ia;
        }
        static int CountC(string str)
        {
            if (str.Length < 1)
            {
                return 0;
            }
            int c = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'C')
                {
                    c++;
                }
            }
            return c;
        }
        static string Change(string str)
        {
            string stringer;
            if (str.Length < 1)
            {
                return str;
            } else
            {
                stringer = str.Replace("BASIC", "Delphi");
            }
            return stringer;
        }
        static string AStart(string str)
        {
            string[] words = str.Split(' ');
            string result = "";
            Console.WriteLine("Result Of Separation: ");
            foreach (var word in words)
            {
                if (word[0] == 'a'){
                    result = word;
                }
                Console.WriteLine($"{word}");
            }
            return result;
        }
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("---Zavd_1---");
            Console.WriteLine("Enter string:");
            str = Console.ReadLine();
            Console.WriteLine($"String contained {CountB(str)} B {CountA(str)} A {CountS(str)} S {CountI(str)} I {CountC(str)} C ");
            string str_modified;
            str_modified = Change(str);
            Console.WriteLine($"Modified string (param) : {str}");
            Console.WriteLine($"Modified string (result): {str_modified}");
            Console.WriteLine("");
            Console.WriteLine("---Zavd_2---");
            Console.WriteLine($"Last Word With Start Of (a): {AStart(str)}");
            Console.ReadKey();
        }
    }
}
