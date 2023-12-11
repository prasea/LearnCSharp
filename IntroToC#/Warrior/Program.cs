namespace IntroToC_.Warrior
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior thor = new Warrior("Thor", 100, 56, 33);
            Warrior hulk = new Warrior("Hulk", 100, 56, 23);
            MagicWarrior loki = new MagicWarrior("Loki ", 75, 26, 23, 50);
            Battle.StartFight(thor, loki);
        }
    }
}
