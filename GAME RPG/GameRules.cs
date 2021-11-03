using System;
using System.Collections.Generic;
using System.Text;

namespace GAME_RPG
{
	public class GameRules : Game
	{
		public void IsHeroDead(Hero Hero)
        {
            if (Hero.Health <= 0)
            {
                Console.Clear();
                Console.WriteLine("On dirais bien que tu es mort!");
                Console.WriteLine("C'est vraiment pas de chance");
				// NbExpEarned = 0;
				// NbMonsterKill = 0;
			}
        }
    }
}
