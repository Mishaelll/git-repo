﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            
            HorizontalLine line = new HorizontalLine(0,Console.WindowWidth-1,0,'*');
            line.Draw();
            

            Console.ReadLine();
        }
    }
}
