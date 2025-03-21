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
            /*Randomizer.Seed = new Random(int.Parse(args[0]));
            Faker faker = new Faker();
            */


            AnsiConsole.Write(new BarChart()

            .AddItem("Ferrari", 14)
            .AddItem("Smart", 4)
            .AddItem("Lamborghini", 4));
            
            

            








        
        }
    }
}
