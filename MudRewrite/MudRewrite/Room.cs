using System;

namespace MudRewrite
{
	public class Room
	{
		
		public string Name;
		public string Description;
		public string[]Moves=new string[6];
		public string[]Results=new string[6];
		public string[]Characters=new string[6];
		public string Glance;
		public Room(String name,string description,string[]moves,string[]results,string[]characters,string glance){
			name = this.Name;
			description = this.Description;
			moves = this.Moves;
			results = this.Results;
			characters = this.Characters;
			glance = this.Glance;
		}
	

	}
}

