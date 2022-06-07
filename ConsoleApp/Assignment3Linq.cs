using System;
using System.Collections.Generic;
using System.Linq;

class AssignentLinq
{
    List<float> bills = new() { 23.5f, 56.2f, 45.1f, 90.34f, 12.23f, 78.65f };
    private object tolerance;

    public void CheckValueOfBill()
    {
        // Select all bills higher or equal to 50$
        var results = bills.Where(bill => bill >= 50.0f).ToArray();

        // Round all bills to nereast integer
        var roundedBills = bills.Select(x => Math.Round(x));

        PrintData<float>(results);
        Console.WriteLine();
        PrintData<double>(roundedBills);

        void PrintData<T>(IEnumerable<T> items)
        {
            foreach (var item in items)
            Console.Write($"{item} ");
        }
    }

}