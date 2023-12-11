namespace IntroToC_.Warrior
{
    class Battle
    {
        //StartFight
        //war1 attacks war2, war2 is damaged and health decreases
        //Get attack result
        //war2 attacks war1, war1 is damaged and health decreases
        //Get attack result

        public static void StartFight(Warrior warrior1, Warrior warrior2)
        {
            while (true)
            {
                if (GetAttackResult(warrior1, warrior2) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
                if (GetAttackResult(warrior2, warrior1) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }

            }
        }

        //Get attack result 
        public static string GetAttackResult(Warrior warriorA, Warrior warriorB)
        {
            double warAAttkAmt = warriorA.GetAttack();
            double warBBlockAmt = warriorB.GetBlock();

            double dmg2WarB = warAAttkAmt - warBBlockAmt;

            if (dmg2WarB > 0)
            {
                warriorB.Health = warriorB.Health - dmg2WarB;
            }
            Console.WriteLine("{0} attacks {1} and Deals {2} damage", warriorA.Name, warriorB.Name, dmg2WarB);
            Console.WriteLine("{0} has {1} health \n", warriorB.Name, warriorB.Health);

            if (warriorB.Health <= 0)
            {
                Console.WriteLine("{0} has died and {1} is victorious", warriorB.Name, warriorA.Name);
                return "Game Over";
            }
            else
            {
                return "Fight AGain";
            }
        }
    }
}
