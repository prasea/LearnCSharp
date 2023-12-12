﻿namespace IntroToC_.Collections
{
    class Person
    {
        public string Name { get; set; }
        public Person(string name = "No Name")
        {
            Name = name;
        }


        public static void GetSum<T>(ref T num1, ref T num2)
        {
            double dblX = Convert.ToDouble(num1);
            double dblY = Convert.ToDouble(num2);
            Console.WriteLine($"{dblX} + {dblY} = {dblX + dblY}");
        }
    }
}
