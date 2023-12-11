namespace IntroToC_.Warrior
{
    class Warrior
    {
        public string Name { get; set; }
        public double Health { get; set; }
        public double AttkMax { get; set; }
        public double BlockMax { get; set; }

        Random rnd = new Random();
        public Warrior(string name = "Warrior", double health = 0, double attkMax = 0, double blockMax = 0)
        {
            Name = name;
            Health = health;
            AttkMax = attkMax;
            BlockMax = blockMax;
        }
        public double GetAttack()
        {
            return rnd.Next(1, (int)AttkMax);
        }
        public virtual double GetBlock()
        {
            return rnd.Next(1, (int)BlockMax);
        }

    }
}
