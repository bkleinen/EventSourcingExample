using System;

namespace TrackShips
{
	public abstract class DomainEvent
	{
		private DateTime recorded, occurred;
		
		public DomainEvent (DateTime datetime)
		{
			this.recorded = DateTime.Now;
			this.occurred = datetime;
		
		}

		internal abstract void Process ();
	}
}

