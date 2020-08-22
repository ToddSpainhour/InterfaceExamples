using System;
using System.Collections.Generic;

namespace InterfaceExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interface Examples");

            var duck = new Duck();
            var plane = new Airplane();
            var helicopter = new Helicopter();

            var flyingThings = new List<IFlyable> { duck, plane, helicopter };

            foreach (var thing in flyingThings)
            {
                if (thing is ITakeOff takeOff)
                {
                    takeOff.TakeOff("Bahamas");
                }

                thing.Fly();
            }



        }
    }
}


// what's the difference between an abstract class and a interface