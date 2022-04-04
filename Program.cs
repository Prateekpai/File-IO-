using System;
using System.IO;
namespace FileIODemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string path = @"E:\LFP 119\Day 27\UC13\UC13\AddressBook.txt";
            ReadAllLinesFromFile(path);
            ReadTextFile(path);

        }

        public static void ReadAllLinesFromFile(string path)
        {
            string[] Line;

            Line = File.ReadAllLines(path);

            Console.WriteLine(Line[0]);
        }

        public static void ReadTextFile(string path)
        {
            string Line;

            Line = File.ReadAllText(path);

            Console.WriteLine(Line);
        }

    }
}
