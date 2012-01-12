using System;

namespace TrackShips
{
	public class Port
	{
		public static readonly Port AT_SEA = new Port("At Sea",Country.AT_SEA);
	
		private String name;
		private Country country;
		public Port (String name, Country country)
		{
			this.name = name;
			this.country = country;
		}
	}
}

