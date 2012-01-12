using System;

namespace TrackShips
{
	public class DepartureEvent : DomainEvent
	{
		private Port port;
		private Ship ship;
	
		public DepartureEvent (DateTime datetime, Port port, Ship ship) : base(datetime)
		{
			this.port = port;
			this.ship = ship;

		}

		internal Port Port   { get { return port; } }

		internal Ship Ship   { get { return ship; } }

		internal override void Process ()
		{
			Ship.HandleDeparture (this);

		}
	}
}

