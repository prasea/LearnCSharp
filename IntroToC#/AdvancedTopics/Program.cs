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

        public static void Main(string[] args)
        {
            Program pg = new Program();
            pg.DelegateDemo();
        }
    }

}
