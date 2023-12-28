using System;
using System.Runtime.ConstrainedExecution;

namespace FactoryPattern
{
	public class AcousticBass : IBassGuitars
	{
	
        public void Play()
        {
            Console.WriteLine("Building a new acoustic bass guitar!");
        }
        

    }
}

