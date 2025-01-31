﻿using sdc1_knowledge_check_2.Class;


// This project is my attempt to adjust the assignment to fit my needs at work. Without context, it may not make sense.

class Program
{
    static void Main()
    {
        Console.WriteLine("How many orders do you want to add? ");
        var numberOfRecords = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfRecords; i++)
        {
            List<Orders> recordList = new List<Orders>();

            Console.WriteLine("Enter Customer Order Data:");
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

            Orders order = new()
            {
                Name = name,
                PartNumber = part,
                Quantity = quantity,
                DayofWeek = day,
                Trial = trial
            };

            recordList.Add(order);


            Console.WriteLine("Record List:");
            foreach (var item in recordList)
            {
                try
                {
                    Console.WriteLine(item.ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error printing order: " + ex.Message);
                }
            }

            Console.WriteLine("Number of records: " + recordList.Count);

            Console.WriteLine("Press any key to continue...");

            Console.ReadKey();
        }
    }
}