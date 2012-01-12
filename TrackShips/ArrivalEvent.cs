using System;

namespace TrackShips
{
	public class ArrivalEvent : DomainEvent
	{
		private Port port;
		private Ship ship;
		public Port Port {
			get {
				return port;
			}
			set {
				port = value;
			}
		}

		public ArrivalEvent (DateTime datetime, Port port, Ship ship) : base (datetime)
		{
			this.port = port;
			this.ship = ship;
		}
		internal override void Process(){
			ship.HandleArrival(this);
		}
	}
}

