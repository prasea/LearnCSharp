namespace IntroToC_
{
    abstract class Shape
    {
        public string Name { get; set; }
        //Non Abstract method in abstract class
        public virtual void GetInfo()
        {
            Console.WriteLine($"This is {Name}");
        }
        //Abstract method in abstract class
        public abstract double Area();
    }
}
//Call from Program's Main
//Shape[] shapes = { new Circle(5), new Rectangle(5, 10) };
//foreach (Shape s in shapes)
//{
//    s.GetInfo();
//    Console.WriteLine("{0} Area is {1:f2}", s.Name, s.Area());

//    Circle testCirc = s as Circle;
//    if (testCirc == null)
//    {
//        Console.WriteLine("The shape is not Circle");
//    }

//    if (s is Circle)
//    {
//        Console.WriteLine("The shape is not Rectangle");
//    }
//}
//Object circ1 = new Circle(5);
//Circle circ2 = (Circle)circ1;
//Console.WriteLine($"The Area of {circ2.Name} is {circ2.Area()}");