using System;

namespace AssemblyCSharp
{
	public class Player
	{
		public string name;
		public int score;

		public Player ()
		{
		}

		public string getName(string name){
			return name;
		}

		public int getScore(int score){
			return score;
		}

		public void setName(string name){
			this.name = name;
		}

		public void setScore(int score){
			this.score = score;
		}
	}
}

