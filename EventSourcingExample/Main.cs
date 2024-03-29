using System;
using System.Linq;
using TrackShips;
namespace EventSourcingExample
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			MyClass test = new MyClass();
			Console.WriteLine ("Hello {0}",test);
			
		    string sentence = "the quick brown fox jumps over the lazy dog";

            // Split the string into individual words.
            string[] words = sentence.Split(' ');

            // Prepend each word to the beginning of the 
            // new sentence to reverse the word order.
            string reversed = words.Aggregate("initval", (workingSentence, next) =>
                                                  next + " " + workingSentence);

            Console.WriteLine(reversed);

            // This code produces the following output:
            //
            // dog lazy the over jumps fox brown quick the 
			
			
			int[] expenses = new int[]{100, -12, -8, 1, -14};
			
			int total = expenses.Aggregate((sum,next) => sum+next);
			
			Console.WriteLine ("You own {0} EUR",total);
			
			
		}
	}
}
