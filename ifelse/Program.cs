﻿using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = 22;
            if(time < 10)
            {
                Console.WriteLine("Good Morning!");
            }
            else if(time < 20)
            {
                Console.WriteLine("Good day!");
            }
            else
            {
                Console.WriteLine("Good evening!");
            }
        }
    }
}