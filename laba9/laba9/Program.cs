using System;
using System.IO;

struct Passenger
{
    public int NumberOfItems;
    public int TotalWeight;
}

class Program
{
    static void Main()
    {
        int k = ReadKValue();
        Passenger[] passengers = ReadPassengers();
        int passenger1Index, passenger2Index;
        bool found = FindMatchingPassengers(passengers, k, out passenger1Index, out passenger2Index);
        WriteResults(found, passenger1Index, passenger2Index);
        Console.WriteLine("Результаты записаны в файл Outlet.out");
    }

    static int ReadKValue()
    {
        string inputFile = "Inlet.in";
        string[] lines = File.ReadAllLines(inputFile);
        return int.Parse(lines[0]);
    }

    static Passenger[] ReadPassengers()
    {
        string inputFile = "Inlet.in";
        string[] lines = File.ReadAllLines(inputFile);

        int numberOfPassengers = (lines.Length - 1) / 2;
        Passenger[] passengers = new Passenger[numberOfPassengers];

        for (int i = 0; i < numberOfPassengers; i++)
        {
            passengers[i].NumberOfItems = int.Parse(lines[i * 2 + 1]);
            passengers[i].TotalWeight = int.Parse(lines[i * 2 + 2]);
        }

        return passengers;
    }

    static bool FindMatchingPassengers(Passenger[] passengers, int k, out int passenger1Index, out int passenger2Index)
    {
        int numberOfPassengers = passengers.Length;
        passenger1Index = -1;
        passenger2Index = -1;

        for (int i = 0; i < numberOfPassengers - 1; i++)
        {
            for (int j = i + 1; j < numberOfPassengers; j++)
            {
                if (passengers[i].NumberOfItems == passengers[j].NumberOfItems &&
                    Math.Abs(passengers[i].TotalWeight - passengers[j].TotalWeight) <= k)
                {
                    passenger1Index = i;
                    passenger2Index = j;
                    return true;
                }
            }
        }

        return false;
    }

    static void WriteResults(bool found, int passenger1Index, int passenger2Index)
    {
        string outputFile = "Outlet.out";
        using (StreamWriter writer = new StreamWriter(outputFile))
        {
            if (found)
            {
                writer.WriteLine($"{passenger1Index + 1} {passenger2Index + 1}");
            }
            else
            {
                writer.WriteLine("-1");
            }
        }
    }
}
