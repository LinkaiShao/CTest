using System;
using System.IO;
using System.Configuration;
using System.Collections.Generic;
namespace IndexBookBinary
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string choice = args [0];
			List<string> addressbook=new List<string>();
			addressbook.AddRange (File.ReadAllLines (choice));
			addressbook.Sort ();
			Console.WriteLine ("type in what you want to find");
			string WantToFind = Console.ReadLine ();
			BinaryFind (addressbook, WantToFind);




		}
		public static void BinaryFind(List<string>addressbook,string WantToFind){
			int min = 0;
			int max = addressbook.Count - 1;
			int middle = max - (max - min) / 2;
			while (true) {
				if (WantToFind.CompareTo (addressbook [middle]) == 1) {
					min = middle;
					if (max <= min) {
						Console.WriteLine ("not found");
						return;
					} else if (max - min == 1) {
						if (addressbook [max] == WantToFind) {
							Console.WriteLine ("found at {0}", max);
							return;
						} else if (addressbook [min] == WantToFind) {
							Console.WriteLine ("found at{0}", min);
							return;
						}
	
					} 

				} else if (WantToFind.CompareTo (addressbook [middle]) == -1) {
					max = middle;
					if (max <= min) {
						Console.WriteLine ("not found");
						return;
					} else if (max - min == 1) {
						if (addressbook [max] == WantToFind) {
							Console.WriteLine ("found at {0}", max);
							return;
						} else if (addressbook [min] == WantToFind) {
							Console.WriteLine ("found at{0}", min);
							return;
						}

					} 
				} else if (WantToFind.CompareTo (addressbook [middle]) == 0) {
					Console.WriteLine ("found at {0}", middle);

					return;
				}else{
					Console.WriteLine ("not found");

					return;
				}

				middle = max - (max - min) / 2;
				if ((max-(max - min) / 2) < 1) {
					middle = 0;
				}

			}

		}
	}
}

