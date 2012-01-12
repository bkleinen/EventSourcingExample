using System;
using NUnit.Framework;
using TrackShips;


namespace TrackShipsTest
{
	[TestFixture()]
	public class TrackShipsTest
	{
		Ship kr;
		Port sfo, la, yyv;
		Cargo refact;
		EventProcessor eventProcessor;
		[SetUp]
		public void SetUp(){
			eventProcessor = new EventProcessor();
			refact = new Cargo ("Refactoring");
			kr = new Ship ("King Roy");
			sfo = new Port("San Francisco", Country.US);
			la = new Port ("Los Angeles", Country.US);
			yyv = new Port("Vancouver",Country.CANADA);
		}
	  [Test]
	  public void ArrivalSetsShipsLocation() {
	    ArrivalEvent ev = new ArrivalEvent(new DateTime(2005,11,1), sfo, kr);
	    eventProcessor.Process(ev);
	    Assert.AreEqual(sfo, kr.Port);
	  }
	  [Test]
	  public void DeparturePutsShipOutToSea() {
	    eventProcessor.Process(new ArrivalEvent(new DateTime(2005,10,1), la, kr));
	    eventProcessor.Process(new ArrivalEvent(new DateTime(2005,11,1), sfo, kr));
	    eventProcessor.Process(new DepartureEvent(new DateTime(2005,11,1), sfo, kr));
	    Assert.AreEqual(Port.AT_SEA, kr.Port);    
		
		}
	}
}

