using System;
using System.Collections.Generic;
using System.Text;

namespace GAME_RPG
{
	public class stats
	{
		public int Attack;
		public int Strength;
		public int Intelligence;
		public int Dexterity;
		public int Health;
		public int XP;
		public int MaxXp;
		public int Money;

		public stats(int _Attack, int _Strength, int _Intelligence, int _Dexterity, int _Health, int _XP, int _Money, int _MaxXp)
		{
			Attack = _Attack;
			Strength = _Strength;
			Intelligence = _Intelligence;
			Dexterity = _Dexterity;
			Health = _Health;
			XP = _XP;
			Money = _Money;
			MaxXp = _MaxXp;
		}

		public void PrintStats()
		{
			Console.WriteLine("Attack value is: {0}", Attack);
			Console.WriteLine("Strength value is: {0}", Strength);
			Console.WriteLine("Intelligence value is: {0}", Intelligence);
			Console.WriteLine("Dexterity value is: {0}", Dexterity);
			Console.WriteLine("Health value is {0}", Health);
			Console.WriteLine("You have {0} XP", XP);
		}

		
	}
}
