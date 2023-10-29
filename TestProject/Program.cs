﻿using System;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int daysUntilExpiration = random.Next(12);
            int discountPercentage = 0;

            Console.WriteLine(daysUntilExpiration);
            if(daysUntilExpiration == 0)
            {
                Console.WriteLine("Your subscription has expired.");
            }
            else if(daysUntilExpiration == 1)
            {
                Console.WriteLine("Your subscription expires within a day! Renew now and save 20%!");
            }
            else if(daysUntilExpiration <= 5)
            {
                Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days. Renew now and save 10%!");
            }
            else if(daysUntilExpiration <= 10)
            {
                Console.WriteLine("Your subscription will expire soon. Renew now!");
            }
            else
            {
            }
        }
    }
}