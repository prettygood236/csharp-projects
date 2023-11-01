using System;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] OrderIDs = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};
            foreach (string OrderID in OrderIDs)
            {
                if (OrderID.StartsWith("B"))
                {
                    Console.WriteLine(OrderID);
                }
            }
        }
    }
}