using System;

namespace Muddddddd
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Piece prelogue = new Piece ();
			var current = prelogue;
			prelogue.scene="'He was fast.'the young ninja thought as he watched his opponent dashes through every single guard as he sliced through their bodies like hot knife against butter.";
			prelogue.choices[0]="prelogue 2";
			prelogue.effect[0]="prelogue 2:";
			Decipher (current, null);

			Piece prelogue2=new Piece();
			current = prelogue2;
			prelogue2.scene = "'And so just like that, the tokugawa shogunate emporor was assasinated, causing an uproar of rebellion forces from other regions.'";
			prelogue2.choices [0] = "town1";
			prelogue2.effect[0]="Blending in with the plebians, you thought you could hide from your sin.";
			Decipher (current, prelogue);

			Piece town1 = new Piece ();
			current = town1;
			town1.scene = "'Tea could be a goo choice' you thought'. Yaki's tea is two blocks away.";
			town1.choices [0] = "forwad";
			town1.effect [0] = "You walked forward, the winter's cold pierced through your bones";
			Decipher (current, prelogue2);

			Piece town2 = new Piece ();
			current = town2;
			town2.scene = "With the broken katana in your hand, you felt uneasy.";
			town2.choices[0]="forward";
			town2.effect [0] = "The road is full of people, an old man with bamboo stick was quite intriguing.";
			Decipher (current, town1);

			Piece town3 = new Piece ();
			current = town3;
			town3.scene = "The right side is the tea place.";
			town3.choices[0]="go in";
			town3.effect [0] = "As usual.";
			Decipher (current, town2);

			Piece TeaEncounter = new Piece ();
			current = TeaEncounter;
			TeaEncounter.scene = "The fresh green tea heated you up, just take it slow...";
			TeaEncounter.choices [0] = "Drink";
			TeaEncounter.effect [0] = "A man with long hair walked in. His scar on his face and his golden katana handel made him seem experienced as a fighter. 'One cup of tea.' He said with an asperity in his voice";
			Decipher (current, town3);

			Piece TeaEncounter2 = new Piece ();
			current = TeaEncounter2;
			TeaEncounter2.scene = "'I'm not paying, someone who's as skillful as me shall be looked upon.'";
			TeaEncounter2.choices [0] = "intimidate";
			TeaEncounter2.choices[1]="spectate";
			TeaEncounter2.effect [0] = "'Here, if you can beat me while I'm barehanded, you can have my sword, but if not, you have to pay up.'";
			TeaEncounter2.effect [1] = "Smashes the cup";
			Decipher (current, TeaEncounter);
			if (TeaEncounter2.Typed == "intimidate") {
				Piece TeaEncounterA1=new Piece();
				current = TeaEncounterA1;
				TeaEncounterA1.scene = "'The name is Yasuo'Takes out his sword and spinned in a whirlwind";
				TeaEncounterA1.choices [0] = "Slash";
				TeaEncounterA1.choices [1] = "Counter";
				TeaEncounterA1.effect [0] = "Yato was way faster, a simple little swing brought yasuo to his knees. His knee cap bleeding from the strike,'I will pay, I will pay.'";
				TeaEncounterA1.effect [1] = "With a swift counter, Yasuo held his sword unsteadily. Yato spinned his sword around. In the blink of a second, Yasuo's chest was sprarying blood.'I will pay, I will pay'";
				Decipher(current,TeaEncounter2);
			} else {
				Piece TeaEncounterB1 = new Piece ();
				current = TeaEncounterB1;
				TeaEncounterB1.scene = "'And of course, I'm in a hurry.'";
				TeaEncounterB1.choices [0] = "The old man, the owner of the tea shop took a broom. In a swift second, Yasuo was brought to his knees.";
				TeaEncounterB1.choices[1]="spectate";
				TeaEncounterB1.effect [0] = "Yasuo cried'I will pay, I will pay.'";
				Decipher (current,TeaEncounter2);
			}
		}
		public static void Decipher(Piece item,Piece Previous){
			item.previous = Previous;
			Previous.next = item;
			if (item.scene != null) {
				Console.WriteLine (item.scene);
			}
			if (item.choices != null) {
				Console.WriteLine ("moves:");
				Console.WriteLine ();
				Console.WriteLine ();
				for (int i = 0; i < item.choices.Length; i++) {
					Console.WriteLine ("{i}      ", item.choices [i]);
				}
			}
			top:
			bool typed = false;
			string playerAction = Console.ReadLine();
			if (playerAction == "previous") {
				item = item.previous;
				Copy (item, item.previous);
				return;
			}
			for (int i = 0; i < item.effect.Length; i++) {
				if (playerAction == item.choices [i]) {
					Console.WriteLine (item.effect [i]);
					typed = true;
				}
			}
			if (typed == false) {
				Console.WriteLine ("your choice does not match the choices provided.");
				goto top;
			}
			item.Typed=playerAction;
			return;

		}
		public static void Copy(Piece item,Piece previous){
			item.previous = previous;
			previous.next = item;
			if (item.scene != null) {
				Console.WriteLine (item.scene);
			}
			if (item.choices != null) {
				Console.WriteLine ("moves:");
				Console.WriteLine ();
				Console.WriteLine ();
				for (int i = 0; i < item.choices.Length; i++) {
					Console.WriteLine ("{i}      ", item.choices [i]);
				}
			}
			top:
			bool typed = false;
			string playerAction = Console.ReadLine();
			if (playerAction == "previous") {
				item = item.previous;
				Decipher (item, item.previous);
				return;
			}
			for (int i = 0; i < item.effect.Length; i++) {
				if (playerAction == item.choices [i]) {
					Console.WriteLine (item.effect [i]);
					typed = true;
				}
			}
			if (typed == false) {
				Console.WriteLine ("your choice does not match the choices provided.");
				goto top;
			}
			item.Typed=playerAction;

		}
	
	}
}
