namespace IntroToC_
{
    class Animal
    {
        public string name;
        public string sound;
        static int numOfAnimal = 0;
        public Animal()
        {
            name = "No Name";
            sound = "No Sound";
            numOfAnimal++;
        }

        public Animal(string name = "NO Name")
        {
            this.name = name;
            this.sound = "No Sound";
            numOfAnimal++;
        }

        public Animal(string name = "No Name", string sound = "No Sound")
        {
            this.name = name;
            this.sound = sound;
            numOfAnimal++;
        }
        public void MakeSound()
        {
            Console.WriteLine("{0} says {1}", this.name, this.sound);
        }
        public static int GetAnimalCount()
        {
            return numOfAnimal;
        }
    }
}
