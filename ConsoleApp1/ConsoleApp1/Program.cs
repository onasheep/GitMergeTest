﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // {   2023, 07 , 03. Modified class position / Alpha

        public class Ruler
        {
            private const float ONE_INCH = 2.54F;
            public int Centimeter { get; set; }
            public float Inch
            {
                get { return Centimeter * ONE_INCH; }
                private set { Centimeter = (int)(value / ONE_INCH); }
            }

            public Ruler(int cmValue)
            {
                Centimeter = cmValue;
            }

            public void Run()
            {
                Console.WriteLine($"{this.Centimeter}cm 는 {this.Inch}inch 입니다.");
            }
        }
    internal class Program
    {   
        
        
        static void Main(string[] args)
        {
            Ruler ruler = new Ruler(10);
            ruler.Run();

        }
    }
}
