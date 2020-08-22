using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExamples
{
    class Duck : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("I'm a duck! Let's fly!");
        }
    }


    // Airplane implements IFlyable or Airplane implements ITakeOff
    class Airplane : IFlyable, ITakeOff
    {
        public void Fly()
        {
            Console.WriteLine("I'm a plane! Need to get somewhere quick?");
        }

        public void TakeOff(string destination)
        {
            Console.WriteLine($"Taking off to go to {destination}");
        }
    }


    // Helicopter implements IFlyable or Helicopter implements ITakeOff
    class Helicopter :IFlyable, ITakeOff
    {
        public void Fly()
        {
            Console.WriteLine("Get to the choppa!");
        }

        public void TakeOff(string destination)
        {
            Console.WriteLine($"Taking off to go to {destination}");
        }
    }






    // all start with 'I' followed by what they do
    // classes that use this interface 'IFlyable' must have this method 'Fly()'
    // using an interfacei'm obligated to have methods like this'
    interface IFlyable
    {
        void Fly();
    }

    interface ITakeOff
    {
        void TakeOff(string destination);
    }






}


