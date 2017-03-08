using System;
using System.IO;
using System.Configuration;
using System.Collections.Generic;
namespace MudRewrite
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[] read = File.ReadAllLines ("Prelogue1");
			string name = read [0];
			string description = read [1];
			string[]moves=new string[6];
			int ResultPlace=0;
			for (int i = 3; i < read.Length; i++) {
				if (read [i] != "Results:") {
					moves [i - 3] = read [i];
				} else {
					ResultPlace = i;
					break;
				}
			}
			int CharacterPlace=0;
			string[] results = new string[6];
			for (int i = ResultPlace + 1; i < read.Length; i++) {
				if (read [i] != "Characters:") {
					results [i - ResultPlace - 1] = read [i];
				} else {
					CharacterPlace = i;
					break;
				}
			}
			string[] Characters = new string[6];
			int GlancePlace=0;
			for (int i = CharacterPlace + 1; i < read.Length; i++) {
				if (read [i] != "Glance:") {
					Characters [i - CharacterPlace - 1] = read [i];
				} else {
					GlancePlace = i;
					break;
				}
			}
			string Glance;
			if (read [GlancePlace+1] != "Glance:") {
				Glance = read [GlancePlace + 1];
			}
			Room()

		}
	}
}
