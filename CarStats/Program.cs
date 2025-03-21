using System;
using Spectre.Console;

namespace CarStats
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello LP1!");
        
            BarChart bc =new BarChart();
            bc.AddItem("Dacia", 12);
            bc.AddItem("Ferrari", 14);
            bc.AddItem("Smart", 4);
        
        
        }
    }
}
