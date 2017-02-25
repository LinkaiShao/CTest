using System;
using System.Collections.Generic;
namespace LInkListSort
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			List<int> numbers = new List<int> ();
			numbers.Add (1);
			numbers.Add (2);
			numbers.Add (3);
			numbers.Add (4);
			if (numbers.Count == 0) {
				Console.WriteLine ("there has to be more than 0 number to your list");
				return;
			}
			var root = new Num ();
			root.input = numbers [0];
			var item = root;
			for (int i = 1; i < numbers.Count; i++) {
				var current = new Num ();
				current.input = numbers [i];
				item.next = current;
				item = current;
			}
			int max = findMax (root, item);

		}
		public static int findMax(Num root,Num item){
			int currentMax=0;
			var current = root;
			while (current != null) {
				if (current.input > currentMax) {
					currentMax = current.input;					
				} 
				current = current.next;
			}
			return currentMax;
		}
		public static int findMIn(Num root, Num item){
			int currentMin = 0;
			var current = new Num ();
			while (current != null) {
				if (current.input < currentMin) {
					currentMin = current.input;
				}
				current = current.next;
			}
			return currentMin;
		}

	}
}
