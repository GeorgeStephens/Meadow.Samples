﻿using Meadow;
using System.Threading.Tasks;

namespace ST7789_Sample;

public class Program
{
    public static async Task Main(string[] args)
    {
        await MeadowOS.Start(args);
    }
}