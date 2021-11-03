using System;
using System.Collections.Generic;
using System.Text;

namespace GAME_RPG
{
	public class Hero
	{
		public string Surname;
		public string Name;
		public int Level;
		public int NbSlot;
		public List<Items> Stuff;
		public int NbMonsterKill;
		public int NbExpEarned;
		public int Money;
		public int Health;

		// Récupérations des méthodes et attributs de la classe Monstre
		private Monstre monstre;

		// Récupération des méthodes et attributs de la classe Stats
		private stats stats;
		

		
		// On défini le level de Vie (1 en début de jeu) qui ortoie 20 PV 
		public int healLvl = 1, MaxHealth = 20;

		
		// Méthode gérant les attributs lors de la création d'un joueur (stats de base)
		public Hero(stats stats, string _Surname, string _Name, int _XP, int _Money, Monstre monstre)
		{
			Surname = _Surname;
			Name = _Name;
			Level = 1;
			NbSlot = 12;
			stats = stats;
			_XP = 0;
			_Money = 100;
			NbExpEarned = 0;
			NbMonsterKill = 0;
			monstre = monstre;
		}
		
		// Méthode pour récuperer le nom et le prénom du Héros
		public void AskUserInfos()
		{
			Console.WriteLine("Création du personnage...");
			{
				string _Surname;
				Console.WriteLine("Quel est votre prénom ?");
				_Surname = Console.ReadLine();

				string _Name;
				Console.WriteLine("Quel est votre nom ?");
				_Name = Console.ReadLine();
			}
		}


		// Choix du héros pendant un combat
		public void HeroBattle()
		{
			bool correctInput = true;
			int choice = 0, choice2;
			do
			{
				Console.WriteLine("Que veux tu faire ?");
				Console.WriteLine("1. Attaquer");
				Console.WriteLine("2. Soigner");
				Console.WriteLine("3. Autre");
				Console.WriteLine("4. Etre un lache");

				bool test = int.TryParse(Console.ReadLine(), out choice);
				if (!test || choice > 4 || choice <= 0)
				{
					Console.WriteLine("Tu ne peut pas faire ça");
					Console.ReadLine();
					Console.Clear();
					continue;
				}


				if (choice == 1) // Attaquer
				{
					Console.WriteLine("1.Attaque basique");
					Console.WriteLine("2.Utiliser une arme");
					Console.WriteLine("3.Utiliser un sort");
					Console.WriteLine("4. Retour");

					bool test2 = int.TryParse(Console.ReadLine(), out choice2);
					if (!test2 || choice2 > 3 || choice2 <= 0)
					{
						Console.WriteLine("Tu ne peut pas faire ça");
						Console.ReadLine();
						Console.Clear();
						continue;
					}
				}

			} while (correctInput);
		}



		// Méthode lors de la mort d'un monstre
		public void KillAMonster()
		{
			do
			{
				stats.XP += monstre.XpLoot;
				Money += monstre.MoneyLoot;
				NbExpEarned += monstre.XpLoot;
				NbMonsterKill += 1;
			} while (monstre.MonstreDead true);
		}



		// Méthode pour le passage à un nouveau niveau
		public void NewLevel()
		{
			if (stats.XP == stats.MaxXp)
			{
				
			}
		}


		// Méthode changement stats Hero à un nouveau niveau
		public void LevelUp()
		{
			Console.WriteLine("Niveau supérieur !");
			Console.WriteLine("Attaque +4");
			Console.WriteLine("Santé Max +10");
			Console.WriteLine("Santé +5");
			Console.WriteLine("Force +3");
			Console.WriteLine("Intalligence +2");
			Console.WriteLine("Dextérité +3");
			Console.ReadLine();
			Console.Clear();

			stats.Attack += 3;
			MaxHealth += 10;
			stats.Health = MaxHealth;
			stats.Health = Health;
			healLvl += 1;
			stats.Strength += 3;
			stats.Intelligence += 2;
			stats.Dexterity += 3;
			stats.XP = 0;
			stats.MaxXp += 150;
			Level += 1;
		}

		

		public void Heal()
		{
			stats.Health += healLvl;

			if (stats.Health > MaxHealth)
			{
				stats.Health = MaxHealth;
			}
		}
	}
}


