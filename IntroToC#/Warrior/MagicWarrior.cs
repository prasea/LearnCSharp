namespace IntroToC_.Warrior
{
    class MagicWarrior : Warrior
    {
        int teleportChance = 0;
        CanTeleport teleportType = new CanTeleport();

        public MagicWarrior(string name, double health, double attackMax, double blockMax, int teleportChance = 0) : base(name, health, attackMax, blockMax)
        {
            this.teleportChance = teleportChance;
        }
        public override double GetBlock()
        {
            Random rnd = new Random();
            int rndDodge = rnd.Next(1, 100);
            if (rndDodge < this.teleportChance)
            {
                Console.WriteLine($"{Name} {teleportType.Teleport()}");
                return 10000;
            }
            else
            {
                return base.GetBlock();
            }
        }
    }
}
