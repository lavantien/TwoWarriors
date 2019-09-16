using System;
using System.Linq;

namespace TwoWarriors
{
	sealed class Warrior
	{
		private string _name;
		public int MaxHealth { get; set; } = 0;
		public int MaxDamage { get; set; } = 0;
		public int MaxArmor { get; set; } = 0;
		public int CurrentHealth { get; set; } = 0;
		private Random _rd;

		public Warrior() : this("N/A", 0, 0, 0) { }

		public Warrior(string name, int maxHealth, int maxDamage, int maxArmor) {
			_name = name;
			MaxHealth = maxHealth;
			MaxDamage = maxDamage;
			MaxArmor = maxArmor;
			CurrentHealth = maxHealth;
			_rd = new Random();
		}

		public string Name {
			get => _name;
			set {
				if (!value.Any(char.IsDigit)) {
					_name = value;
				} else {
					_name = "N/A";
				}
			}
		}

		public int Attack() => _rd.Next(0, MaxDamage + 1);

		public int Block() => _rd.Next(0, MaxArmor + 1);
	}
}
