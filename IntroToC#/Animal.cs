namespace IntroToC_
{
    class Animal
    {
        private string name;
        private string sound;
        private static int numOfAnimals = 0;
        public const string SHELTER = "Jawlakhel Zoo";
        public readonly int idNum;

        public Animal() : this("No Name", "No Sound") { }
        //public Animal()
        //{
        //    name = "No Name";
        //    sound = "No Sound";
        //    numOfAnimal++;
        //}

        public Animal(string name = "No Name") : this(name, "No Sound") { }
        //public Animal(string name = "NO Name")
        //{
        //    this.name = name;
        //    this.sound = "No Sound";
        //    numOfAnimal++;
        //}

        public Animal(string name, string sound)
        {
            SetName(name);
            Sound = sound;
            NumOfAnimals = 1;

            Random rand = new Random();
            idNum = rand.Next(1, 123);
        }
        //public Animal(string name = "No Name", string sound = "No Sound")
        //{
        //    this.name = name;
        //    this.sound = sound;
        //    NumOfAnimals = 1;
        //}
        public void MakeSound()
        {
            Console.WriteLine("{0} says {1}", this.name, this.sound);
        }
        public static int GetAnimalCount()
        {
            return NumOfAnimals;
        }

        //Getter and Setter
        public void SetName(string name)
        {
            if (name.Any(char.IsDigit))
            {
                this.name = "No Name";
            }
            else
            {
                this.name = name;
            }
        }
        public string GetName()
        {
            return this.name;
        }
        public string Sound
        {
            get { return this.sound; }
            set
            {
                if (value.Length > 10)
                {
                    sound = "No Sound";
                    Console.WriteLine("Sound is too long");
                }
                else
                {
                    sound = value;
                }
            }
        }
        public string Owner { get; set; } = "No Owner";
        public static int NumOfAnimals
        {
            get { return numOfAnimals; }
            set { numOfAnimals += value; }
        }
    }
}
//Use below code to call Animal from Program's Main()
//Animal cat = new Animal();
//cat.SetName("BillyBong");
//cat.Sound = "Meow";
//Console.WriteLine("The cat is named {0} and it says {1}", cat.GetName(), cat.Sound);
//cat.Owner = "Prajanya";
//Console.WriteLine("{0} is owned by {1}", cat.GetName(), cat.Owner);
//Console.WriteLine("{0} shelter id is {1}", cat.GetName(), cat.idNum);
//Console.WriteLine("Number of animals {0} ", Animal.NumOfAnimals);