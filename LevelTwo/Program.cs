﻿using Spectre.Console;

namespace LevelTwo
{
    public class Program
    {
        private static void Main()
        {
            CanvasImage image = new CanvasImage("tux.jpg");

            image.MaxWidth(24);

            AnsiConsole.Write(image);
        }
    }
}
