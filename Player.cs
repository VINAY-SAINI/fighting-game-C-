
namespace PvP
{
    enum SCALE
    {
        LOW = 10,
        MEDIUM = 50,
        HIGH = 100
    }
    class Player
    {
        string _name = "";
        int _health;
        int _damage;
        int _heal;
        public Player(int value)
        {
            _name = " ";
            switch (value)
            {
                case 1:
                    this._name = "UnderTaker";
                    this._health = (int)SCALE.HIGH;
                    this._damage = (int)SCALE.LOW;
                    this._heal = (int)SCALE.LOW;
                    break;
                case 2:
                    this._name = "John Cena";
                    this._health = (int)SCALE.MEDIUM;
                    this._damage = (int)SCALE.MEDIUM;
                    this._heal = (int)SCALE.MEDIUM;
                    break;
                case 3:
                    this._name = "Brock Lesnar";
                    this._health = (int)SCALE.LOW;
                    this._damage = (int)SCALE.HIGH;
                    this._heal = (int)SCALE.HIGH;
                    break;
            }

        }
        public int health
        {
            get { return _health; }
        }
        public string name
        {
            get { return _name; }
        }
        public void Healing()
        {
            if (this._health >= 100)
            {
                Console.WriteLine(".....Oops Your Health is Already Full Try some Acttack on your opponent");
            }
            else if (this.health > 0 && this.health < 100)
            {
                Console.Write($"Great your health improve from {this.health} to ");
                this._health = this._health + this._heal;
                if (this.health > 100)
                {
                    this._health = 100;
                }
                Console.WriteLine(this._health);
            }
            else if (this.health <= 0)
            {
                Console.WriteLine("You are already lost... Better luck next time");
                Environment.Exit(0);
            }
        }
        public void Attack(Player A)
        {
            if (A.health < 0)
            {
                Console.WriteLine($"{A._name} already lost... Better luck next time");
                Environment.Exit(0);
            }
            else if (A.health > 0)
            {
                A._health = A.health - this._damage;
                Console.WriteLine($"Heath of {A.name} is {A.health}");
                if (A.health <= 0)
                {
                    Console.WriteLine($"{this._name} Wins ... Better Luck next time {A._name}");
                }
            }
        }
    }
}