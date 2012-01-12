using System;

namespace TrackShips
{
	public class Ship
	{
		private String name;
		private Port port;

		public Port Port {
			get {
				return port;
			}
			set {
				port = value;
			}
		}

		public Ship (String name)
		{
			this.name = name;
		}

		public void HandleDeparture (DepartureEvent departureEvent)
		{
			Port = Port.AT_SEA;
		}
		public void HandleArrival (ArrivalEvent arrivalEvent){
			Port = arrivalEvent.Port;
		}
	}
}

