namespace IntroToC_
{
    class Dog : Animal2
    {
        public string Sound2 { get; set; } = "No Sound";
        public Dog(string name = "No Name", string sound = "No Sound", string sound2 = "No Sound") : base(name, sound)
        {
            Sound2 = sound2;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound} and {Sound2}");
        }
    }
}
