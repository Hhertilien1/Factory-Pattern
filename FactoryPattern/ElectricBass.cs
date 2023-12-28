using System;
namespace FactoryPattern
{
	public class ElectricBass : IBassGuitars

	{

        public void Play()
        {
            Console.WriteLine("Building a new electric bass guitar!");
        }
    }

   
}

