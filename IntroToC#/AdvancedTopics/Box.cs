namespace IntroToC_.AdvancedTopics
{
    class Box
    {
        public double Length { get; set; }
        public double Breadth { get; set; }
        public double Width { get; set; }
        public Box() : this(1, 1, 1) { }
        public Box(double length, double breadth, double width)
        {
            Length = length;
            Breadth = breadth;
            Width = width;
        }

        public static Box operator +(Box box1, Box box2)
        {
            Box box = new Box()
            {
                Length = box1.Length + box2.Length,
                Breadth = box1.Breadth + box2.Breadth,
                Width = box1.Width + box2.Width
            };
            return box;
        }
        public static Box operator -(Box box1, Box box2)
        {
            Box box = new Box()
            {
                Length = box1.Length - box2.Length,
                Breadth = box1.Breadth - box2.Breadth,
                Width = box1.Width - box2.Width
            };
            return box;
        }

        public static bool operator ==(Box box1, Box box2)
        {
            if ((box1.Length == box2.Length) && (box1.Breadth == box2.Breadth) && (box1.Width == box2.Width))
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Box box1, Box box2)
        {
            if ((box1.Length != box2.Length) || (box1.Breadth != box2.Breadth) || (box1.Width != box2.Width))
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return String.Format("Box with height : {0} Width : {1} and Breadth : {2}", Length, Width, Breadth);
        }

        //Convert Box dataType into Integer
        public static explicit operator int(Box b)
        {
            return (int)(b.Length + b.Breadth + b.Width) / 3;
        }

        //Convert Integer into Box dataType
        public static implicit operator Box(int i)
        {
            //return new Box() { Length = i, Breadth = i, Width = i };
            return new Box(i, i, i);
        }
    }
}
