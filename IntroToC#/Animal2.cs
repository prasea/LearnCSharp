namespace IntroToC_
{
    class Animal2
    {
        private string name;
        private string sound;

        public string Name { get; set; } = "No Name";
        public string Sound { get; set; } = "No Sound";

        public Animal2() : this("No Name", "No Sound") { }
        public Animal2(string name) : this(name, "No Sound") { }
        public Animal2(string name, string sound)
        {
            Name = name;
            Sound = sound;
        }

        protected AnimalIdInfo animalIdInfo = new AnimalIdInfo();

        public void SetAnimalIdInfo(int idNum, string owner)
        {
            animalIdInfo.IdNum = idNum;
            animalIdInfo.Owner = owner;
        }
        public void GetAnimalIdInfo()
        {
            Console.WriteLine($"{Name} has the Id of {animalIdInfo.IdNum} and is owned by {animalIdInfo.Owner}");
        }
        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound}");
        }

        public class Animal2Health
        {
            public bool HealtyWeight(double ht, double wt)
            {
                double calc = ht / wt;
                if ((calc > 0.10 && calc < 0.10))
                {
                    return true;
                }
                else
                    return false;
            }
        }



    }
}

//Call Animal2 and Dog from Program's Main()
//Animal2 ant = new Animal2()
//{
//    Name = "Ant",
//    Sound = "Ting"
//};
//Dog dusky = new Dog()
//{
//    Name = "Dusky",
//    Sound = "Vow",
//    Sound2 = "Vow Vow"
//};
//ant.SetAnimalIdInfo(12, "Billy Bob");
//dusky.SetAnimalIdInfo(21, "Bob Billy");
//ant.GetAnimalIdInfo();
//dusky.GetAnimalIdInfo();

//ant.MakeSound();
//dusky.MakeSound();

//Animal2.Animal2Health health = new Animal2.Animal2Health();
//Console.WriteLine($"{dusky.Name} is healty {health.HealtyWeight(20, 60)}");