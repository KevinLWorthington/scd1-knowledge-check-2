using System;
using System.Collections.Generic;
using sdc1_knowledge_check_2.Class;

// This project is my attempt to adjust the assignment to fit my needs at work. Without context, it will likely not make sense.

class Program
{
    static void Main()
    {
        List<Trial> recordList = [];

        Console.WriteLine("Enter Customer Trial Order Data:");
        Console.Write("Name: ");
        string? name = Console.ReadLine();
        Console.Write("Part Number: ");
        int part = Convert.ToInt32(Console.ReadLine());
        Console.Write("Part Quantity: ");
        int quantity = Convert.ToInt32(Console.ReadLine());
        Console.Write("Description: ");
        string? day = Console.ReadLine();
        Console.Write("Is the order a QCS trial? (Y/N): ");
        string? trial = Console.ReadLine();

        Trial customer = new()
        {
            Name = name,
            PartNumber = part,
            Quantity = quantity,
            DayofWeek = day,
            Qcs = trial
        };

        recordList.Add(customer);

        Console.WriteLine("Record List:");
        foreach (var item in recordList)
        {
            Console.WriteLine(item.ToString());
        }
    }
}