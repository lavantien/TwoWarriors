using System;

namespace TwoWarriors
{
	class Battle
	{
		private static int counter = 1;

		public static void StartFight(Warrior w1, Warrior w2) {
			bool isVictory = false;
			for (int i = 0; ; ++i) {
				if (i == 0) {
					GetAttackResult(w1, w2, out isVictory);
				} else {
					GetAttackResult(w2, w1, out isVictory);
				}
				if (isVictory) {
					break;
				}
				if (i == 1) {
					i = -1;
				}
			}
		}

		private static void GetAttackResult(Warrior w1, Warrior w2, out bool isVictory) {
			if (w2.CurrentHealth <= 0) {
				Console.WriteLine($"{w1.Name} victory!");
				isVictory = true;
				return;
			}
			if (w1.CurrentHealth <= 0) {
				Console.WriteLine($"{w2.Name} victory!");
				isVictory = true;
				return;
			}
			int attack = w1.Attack();
			int block = w2.Block();
			int hpLost = attack - block > 0 ? attack - block : 0;
			int oldCurrHp = w2.CurrentHealth;
			w2.CurrentHealth -= hpLost;
			Console.WriteLine($"* Match {counter}:\n\t{w1.Name} has attacked {w2.Name} for {attack} damage." +
				$"\n\t{w2.Name} has absorbed {block} damage." +
				$"\n\t--> Has {oldCurrHp} HP. {hpLost} HP lost. {w2.CurrentHealth} HP remaining.\n");
			isVictory = false;
			++counter;
		}
	}
}
