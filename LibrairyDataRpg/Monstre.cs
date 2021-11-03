using System;
using System.Collections.Generic;
using System.Text;

namespace GAME_RPG
{
	public class Monstre
	{
		public string Name;
		public int Level;
		public List<Items> Stuff;
		public int NbSlot;
		public string ItemLoot;
		public int XpLoot;
		public int MoneyLoot;

		// Récupération des stats de la classe Stats
		private stats stats;


		public Monstre(stats stats, string _Name)
		{
			Name = _Name;
			NbSlot = 1;
			stats = stats;
		}

		public void DropMoney()
		{
			if (Level == 1)
			{
				Random aleatoire = new Random();
				int NewMoney = aleatoire.Next(25, 75);
				stats.Money = NewMoney;
			}
			if (Level == 2)
			{
				Random aleatoire = new Random();
				int NewMoney = aleatoire.Next(75, 125);
				stats.Money = NewMoney;
			}
			if (Level == 3)
			{
				Random aleatoire = new Random();
				int NewMoney = aleatoire.Next(125, 200);
				stats.Money = NewMoney;
			}
			if (Level == 4)
			{
				Random aleatoire = new Random();
				int NewMoney = aleatoire.Next(200, 300);
				stats.Money = NewMoney;
			}
			if (Level > 4)
			{
				Random aleatoire = new Random();
				int NewMoney = aleatoire.Next(300, 600);
				stats.Money = NewMoney;
			}
			MoneyLoot = stats.Money;
		}



		public void DropXp()
		{
			if (Level == 1)
			{
				Random aleatoire = new Random();
				int NewXpLoot = aleatoire.Next(20, 50);
				stats.XP = NewXpLoot;
			}
			if (Level == 2)
			{
				Random aleatoire = new Random();
				int NewXpLoot = aleatoire.Next(75, 125);
				stats.XP = NewXpLoot;
			}
			if (Level == 3)
			{
				Random aleatoire = new Random();
				int NewXpLoot = aleatoire.Next(125, 200);
				stats.XP = NewXpLoot;
			}
			if (Level == 4)
			{
				Random aleatoire = new Random();
				int NewXpLoot = aleatoire.Next(200, 300);
				stats.XP = NewXpLoot;
			}
			if (Level > 4)
			{
				Random aleatoire = new Random();
				int NewXpLoot = aleatoire.Next(300, 600);
				stats.XP = NewXpLoot;
			}
			XpLoot = stats.XP;
		}




		public bool MonstreDead()
		{
			if (stats.Health == 0)
			{

				return true;
			}
			return false;
		}
	}
}
