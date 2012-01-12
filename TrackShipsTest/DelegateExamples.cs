using System;

namespace TrackShipsTest
{
	public class DelegateExamples
	{
		public DelegateExamples ()
		{
		}

		private String localInDelegateExamples = "the bound value";

		public Func<string,string> SimpleDelegate ()
		{
			Func<string,string> myFunc = delegate(string var1)
			{
				return "Hi. I'm a Delegate and received " + var1 + " as a Parameter";
			};
			return myFunc;
		}

		public Func<string,string> SimpleDelegateUsingLambda ()
		{
			Func<string,string> myFunc = var1 => "Hi. I'm a Delegate and received " + var1 + " as a Parameter";
			return myFunc;
			
		}
		
		public Func<string,string> AClosure ()
		{
			Func<string,string> myFunc = var1 => "Hi. I'm a Delegate and received " + var1 + " as a Parameter" 
				+ " and add a local variable: " + localInDelegateExamples;
			return myFunc;			
		}
	}
}
