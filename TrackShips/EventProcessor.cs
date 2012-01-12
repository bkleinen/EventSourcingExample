using System;
using System.Collections;

namespace TrackShips
{
	public class EventProcessor
	{  
		IList log = new ArrayList ();

		public EventProcessor ()
		{
		}

		public void Process (ArrivalEvent e)
		{
			e.Process ();
			log.Add (e);
		}

		public void Process (DepartureEvent e)
		{
			e.Process ();
			log.Add (e);
		}
		
	}
}

