 using System;
namespace FactoryPattern
{
	public class BassGuitarFactory
	{
		public static IBassGuitars GetBassGuitars(string choice)
		{
			switch (choice)
			{
				case "Acoustic":
					return new AcousticBass();
				case "Electric":
					return new ElectricBass();
				default:
					return new ElectricBass();
			}		
		}

	}
}

