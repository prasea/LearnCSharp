using System.Collections;

namespace IntroToC_.AdvancedTopics
{
    class AnimalFarm : IEnumerable
    {
        private List<Animal> animalList = new List<Animal>();

        public AnimalFarm(List<Animal> animalList)
        {
            this.animalList = animalList;
        }
        public AnimalFarm() { }

        //Creating Indexers
        public Animal this[int index]
        {
            get { return (Animal)animalList[index]; }
            set { animalList.Insert(index, value); }
        }

        public int Count
        {
            get { return animalList.Count; }
        }
        public IEnumerator GetEnumerator()
        {
            return animalList.GetEnumerator();
        }
    }
}
