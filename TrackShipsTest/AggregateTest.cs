using System;
using System.Linq;
using NUnit.Framework;

namespace TrackShipsTest
{
	[TestFixture()]
	public class AggregateTest
	{
		[Test()]
		public void TestCase ()
		{
			 string sentence = "the quick brown fox jumps over the lazy dog";

            // Split the string into individual words.
            string[] words = sentence.Split(' ');

            // Prepend each word to the beginning of the 
            // new sentence to reverse the word order.
            string reversed = words.Aggregate("initval", (workingSentence, next) =>
                                                  next + " " + workingSentence);

            
			Assert.AreEqual("dog lazy the over jumps fox brown quick the initval",reversed);

		}
		[Test]
		public void AggregateExpenses(){
			int[] expenses = new int[]{100, -12, -8, 1, -14};
			
			int total = expenses.Aggregate((sum,next) => sum+next);
			
			Assert.AreEqual(67,total);
			
		}
	}
}