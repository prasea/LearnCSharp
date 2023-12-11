namespace IntroToC_
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Name = "Circle";
            Radius = radius;
        }
        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"It has Radius of {Radius}");
        }
    }
}
