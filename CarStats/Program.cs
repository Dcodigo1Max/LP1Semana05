using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using Bogus;
using Bogus.DataSets;
using Spectre.Console;

namespace CarStats
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Randomizer.Seed = new Random(int.Parse(args[0]));
            Faker faker = new Faker();


            BarChart bc =new BarChart();

            bc.AddItem("Dacia", 12);
            bc.AddItem("Ferrari", 14);
            bc.AddItem("Smart", 4);

            var items = new List<(string label, int Value)>
            {
                ("Dacia", 12),
                ("Ferrari", 14),
                ("Smart", 4),
            };








        
        }
    }
}
