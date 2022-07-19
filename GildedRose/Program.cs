using System;
using System.Collections.Generic;

namespace GildedRoseKata
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello ##########################################################################");
            Console.WriteLine("AUTHOR NAME: TAHA BENHAMMOUDA ##################################################");
            Console.WriteLine("Implemented design patterns: Singleton , Factory ###############################");
            Console.WriteLine("Only c# features");

            //Init data
            var database = new Db();
            var app = new GildedRose(database.productSet);

            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("----------------------------------- Day N:" + (i) + " ---------------------------------");
                foreach (var product in app.Items)
                {
                    Console.WriteLine("   _____________________________________________________");
                    System.Console.WriteLine("  | name:      " + product.Name);
                    System.Console.WriteLine("  | SellIn:    " + product.SellIn);
                    System.Console.WriteLine("  | Quality:   " + product.Quality);
                }
                Console.WriteLine("");
                app.UpdateQuality();
            }
        }
    }
}
