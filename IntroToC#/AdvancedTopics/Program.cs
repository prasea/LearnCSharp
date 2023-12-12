namespace IntroToC_.AdvancedTopics
{
    class Program
    {
        public delegate void Arithmetic(double num1, double num2);
        public static void Add(double num1, double num2)
        {
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        }
        public static void Subtract(double num1, double num2)
        {
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        }
        public delegate double doubleIt(double val);
        public void DelegateDemo()
        {
            Arithmetic add, sub, addSub;
            add = new Arithmetic(Add);
            sub = new Arithmetic(Subtract);
            addSub = add + sub;
            Console.WriteLine("Add 10 and 6");
            add(10, 6);
            Console.WriteLine("Subtract 10 and 6");
            sub(10, 6);
            Console.WriteLine("Add and Subtract 10 and 6");
            addSub(10, 6);

            doubleIt dblIt = x => x * 2;
            Console.WriteLine($" 5 * 2 is {dblIt(5)}");
        }


        public void WhereDemo()
        {
            List<int> numList = new List<int> { 1, 2, 3, 4, 5, 6 };
            var evenList = numList.Where(a => a % 2 == 0).ToList();
            Console.WriteLine(evenList.GetType());
            foreach (var j in evenList) Console.WriteLine("Even Number : {0} ", j);

            var rangeList = numList.Where(a => (a > 2) && (a < 5)).ToList();
            foreach (var j in rangeList) Console.WriteLine("Number in between 2 and 5 is {0} ", j);

            List<int> flipList = new List<int>();
            int i = 0;
            Random rnd = new Random();
            while (i < 100)
            {
                flipList.Add(rnd.Next(1, 3));
                i++;
            }
            Console.WriteLine("Heads Count {0}", flipList.Where(a => a == 1).ToList().Count());
            Console.WriteLine("Tails Count {0}", flipList.Where(a => a == 2).ToList().Count());

            var nameList = new List<string> { "Prajanya", "Pawan", "Pratish", "Nirman" };
            var pNameList = nameList.Where(x => x.StartsWith('P'));
            foreach (var name in pNameList) Console.WriteLine($"{name} starts with P");
        }

        public void SelectDemo()
        {
            var oneTo5 = Enumerable.Range(1, 5).ToList();
            //Select allows us to execute a function fore each item in a List
            var oneTo10 = new List<int>();
            oneTo10.AddRange(Enumerable.Range(1, 10));
            var squares = oneTo10.Select(x => x * x);
            foreach (var res in squares) Console.WriteLine("The square is {0}", res);
        }

        public void LINQMethodsDemo()
        {
            //Zip applies a function to two separate List.
            //Demo : Let's add values in two different List and generate a new List. 
            var listOne = new List<int>(new int[] { 1, 3, 4 });
            var listTwo = new List<int>(new int[] { 4, 6, 8 });
            var sumList = listOne.Zip(listTwo, (x, y) => x + y).ToList();
            foreach (var res in sumList) Console.WriteLine(res);

            //Demo : Sum all the values in the List using Aggreate()
            var numList = new List<int>(new int[] { 1, 2, 3, 4, 5 });
            var sum = numList.Aggregate((a, b) => a + b);
            Console.WriteLine("The sum is {0} ", sum);
            var average = numList.AsQueryable().Average();
            Console.WriteLine("The average is {0}", average);

            //Demo : Determine if all items in the List meet certain condition !
            var allGreaterThan3 = numList.All(x => x > 3);
            Console.WriteLine("Are all the items in numList greater than 3 : {0}", allGreaterThan3);

            //Demo : Determine if any item in the List meet certain condition !
            var anyGreaterThan3 = numList.Any(x => x > 3);
            Console.WriteLine("Are any item in numList greater than 3 : {0}", anyGreaterThan3);

            //Demo : Eiminate duplicate item from the List  
            var duplicatedList = new List<int> { 1, 1, 2, 2, 3, 3, 4, 4 };
            var uniqueList = duplicatedList.Distinct();
            Console.WriteLine("Distinct elements of duplicatedList are {0}", String.Join(",", uniqueList));

            //Demo : From two separate List, return the values not found in both of them !
            var numList2 = new List<int> { 1, 2, 3, 4 };
            var numList3 = new List<int> { 2, 4 };
            var notFoundItems = numList2.Except(numList3);
            Console.WriteLine("Elements in numList2 that are not in numList3 are {0}", String.Join(",", notFoundItems));

            var commonItems = numList2.Intersect(numList3);
            Console.WriteLine("Elements common in both numList2 and numList3 are {0}", String.Join(",", commonItems));
        }
        public static void Main(string[] args)
        {
            AnimalFarm myAnimals = new AnimalFarm();
            myAnimals[0] = new Animal("Dog");
            myAnimals[1] = new Animal("Cat");
            myAnimals[2] = new Animal("Lion");
            myAnimals[3] = new Animal("Tiger");
            foreach (Animal i in myAnimals)
                Console.WriteLine(i.Name);

            Box box1 = new Box(2, 3, 4);
            Box box2 = new Box(5, 6, 7);
            Box box3 = box1 + box2;
            Box box4 = box2 - box1;
            Console.WriteLine($"Box 3 : {box3}");
            Console.WriteLine($"Box 3 as Integer : {(int)box3}");
            Box boxFromInteger = (Box)5;
            Console.WriteLine($"Box From Integer , {boxFromInteger}");


        }
    }

}
