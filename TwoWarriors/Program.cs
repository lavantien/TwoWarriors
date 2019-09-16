using System;

namespace TwoWarriors
{
	class Program
	{
		static void Main(string[] args) {
			Warrior tavatimsa = new Warrior("Tavatimsa", 1000, 120, 60);
			Warrior asura = new Warrior("Asura", 1000, 119, 59);
			Battle.StartFight(tavatimsa, asura);
			Console.ReadLine();
		}

	}
}
