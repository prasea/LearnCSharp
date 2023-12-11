namespace IntroToC_
{
    class ShapeArea
    {
        public static double GetArea(string name, double length1 = 0, double length2 = 0)
        {
            if (String.Equals("rectangle", name, StringComparison.OrdinalIgnoreCase))
            {
                return length1 * length2;
            }
            else if (String.Equals("square", name, StringComparison.OrdinalIgnoreCase))
            {
                return Math.Pow(length1, 2);
            }
            else if (String.Equals("triangle", name, StringComparison.OrdinalIgnoreCase))
            {
                return length1 * (length2 / 2);
            }
            else
            {
                return -1;
            }
        }
    }
}
