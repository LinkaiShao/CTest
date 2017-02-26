using System;

namespace SortTheLinkedList
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine("type in number");
			int number = int.Parse(Console.ReadLine ());
			var root = new Biao ();
			root.input = number;
			var current = root;
			while (true) {
				/*number = int.Parse(Console.ReadLine ());
				var item = new Biao ();
				item.input = number;
				var track = current;
				while (true) {
					if (item.input <= current.input) {
						item.Next = current;
						track.Next = item;
						break;
					} else {
						track = current;
						current = current.Next;
					}
				}
				*/
				Console.WriteLine ("tyep in number");
				number = int.Parse(Console.ReadLine ());
				var item = new Biao ();
				item.input = number;
				var track = current;
				while (true) {
					if (item.input >= current.input) {
						if (current.Next != null) {
							track = current;
							current = current.Next;
						} else {
							item = current.Next;
							current = root;
							break;
						}						
					} else {
						if (track != current) {
							track.Next = item;
							item.Next = current;
							current = root;
							break;
						} else {
							item.Next = current;
							root = item;
							current = root;
							break;
						}
					}
				}
				
			}

		}
	}
}
