using System;
using System.IO;

class Program
{
    static void Main()
    {
        char x = char.ToLower(File.ReadAllText("Inlet.in")[0]);
        string[] lines = File.ReadAllLines("Inlet.in");
        string lastLine = lines[lines.Length - 1];
        int index = lastLine.IndexOf(char.ToLower(x));
        if (index != -1)
        {
            string t = lastLine.Substring(index + 1);
            Console.WriteLine("Значение T было записано в файл Outlet.out");
            File.WriteAllText("Outlet.out", t);
        }
        else
        {
            Console.WriteLine("Значение T было записано в файл Outlet.out");
            File.WriteAllText("Outlet.out", "0");
        }
    }
}
