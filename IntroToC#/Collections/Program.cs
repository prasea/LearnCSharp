using System.Collections;
namespace IntroToC_.Collections
{
    class Program
    {
        #region ArrayList Code
        public void ArrayListDemo()
        {
            ArrayList aList = new ArrayList();
            aList.Add("Ram");
            aList.Add("Sam");
            Console.WriteLine("ArraList Count {0} ", aList.Count);
            Console.WriteLine("ArraList Capacity {0} ", aList.Capacity);

            ArrayList aList2 = new ArrayList();
            aList2.AddRange(new object[] { "Rita", "Sita" });

            aList.AddRange(aList2);

            aList2.Sort();
            aList2.Reverse();

            aList.Insert(2, "Hari");

            aList.RemoveAt(2);
            aList.RemoveRange(0, 2);

            Console.WriteLine("Index of Rita is {0} ", aList2.IndexOf("Rita"));

            foreach (string name in aList2)
            {
                Console.WriteLine(name);
            }
            //Converting ArrayList to String Array
            string[] names = (string[])aList2.ToArray(typeof(string));

            //Converting String Array to ArrayList 
            string[] customers = new string[] { "Bob", "Rob", "Hob" };
            ArrayList custAList = new ArrayList();
            custAList.AddRange(customers);
            foreach (object customer in custAList)
            {
                Console.WriteLine(customer);
            }

        }
        #endregion

        #region Dictionary Codes
        public void DictionaryDemo()
        {
            Dictionary<string, string> capitals = new Dictionary<string, string>();
            capitals.Add("Nepal", "Kathmandu");
            capitals.Add("India", "New Delhi");
            capitals.Add("China", "Beijing");
            capitals.Add("Russia", "Moscow");

            capitals.Remove("Russia");

            Console.WriteLine("Count : {0} ", capitals.Count);
            Console.WriteLine("We know capital city of Nepal?  {0}", capitals.ContainsKey("Nepal"));

            capitals.TryGetValue("India", out string? indianCapital);
            Console.WriteLine("The capital city of India is {0} ", indianCapital);

            foreach (KeyValuePair<string, string> item in capitals)
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Value);
            }
            capitals.Clear();
        }
        #endregion

        public void QueueDemo()
        {
            Queue queue = new Queue();
            queue.Enqueue(5);
            queue.Enqueue(10);
            queue.Enqueue(15);

            Console.WriteLine("Is 5 in queue? {0}", queue.Contains(5));
            Console.WriteLine("Removes the first element {0} from the queue", queue.Dequeue());
            Console.WriteLine("The first element in queue is {0}", queue.Peek());

            foreach (object item in queue)
            {
                Console.WriteLine(item);
            }
            //Copying Queue elements to Array 
            object?[] numArray = queue.ToArray();

            Console.WriteLine(String.Join(", ", numArray));

            queue.Clear();
        }

        public struct Rectangle<T>
        {
            private T length;
            private T breadth;

            public T Length
            {
                get { return length; }
                set { length = value; }
            }
            public T Breadth
            {
                get { return breadth; }
                set { breadth = value; }
            }
            public Rectangle(T l, T b)
            {
                length = l;
                breadth = b;
            }
            public string GetArea()
            {
                double dblLength = Convert.ToDouble(length);
                double dblBreadth = Convert.ToDouble(breadth);
                return string.Format($"{dblLength} * {dblBreadth} = {dblLength * dblBreadth}");
            }
        }
        static void Main(string[] args)
        {
            List<Person> personList = new List<Person>();
            personList.Add(new Person() { Name = "Rob" });
            personList.Add(new Person("Bob"));
            personList.Add(new Person() { Name = "Hob" });

            personList.Insert(0, new Person("Mob"));
            personList.RemoveAt(0);
            Console.WriteLine("Num of Person {0}", personList.Count());

            foreach (Person person in personList)
            {
                Console.WriteLine(person.Name);
            }

            int x = 2, y = 2;
            Person.GetSum<int>(ref x, ref y);
            string strX = "2", strY = "2";
            Person.GetSum<string>(ref strX, ref strY);

            Rectangle<int> rect1 = new Rectangle<int>(10, 20);
            Console.WriteLine(rect1.GetArea());
            Rectangle<string> rect2 = new Rectangle<string>("10", "20");
            Console.WriteLine(rect1.GetArea());
        }

    }
}
