using System;
using System.IO;

class Program
{
    static void Main()
    {
        // в конце каждой строки необходимо ставить пробел(Inlet.in)
        string content = File.ReadAllText("Inlet.in");
        string[] words = content.Split(' ');

        int maxLength = 0;
        int maxIndex = -1;

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length > maxLength)
            {
                maxLength = words[i].Length;
                maxIndex = i;
            }
        }

        int result = maxIndex != -1 ? maxIndex + 1 : -1;
        File.WriteAllText("Outlet.out", result.ToString());
        Console.WriteLine("Результат записан в файл Outlet.out.");
    }
}
