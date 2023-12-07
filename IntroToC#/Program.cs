using System.Globalization;
using System.Text;

class Program
{
    public void StringFunction()
    {
        string randomString = "This is a string"; ;
        Console.WriteLine("String Length " + randomString.Length);
        Console.WriteLine("String Contains 'is' {0}", randomString.Contains("is"));
        Console.WriteLine("Index of 'is' {0}", randomString.IndexOf("is"));
        Console.WriteLine("Remove string {0}", randomString.Remove(10, 6));
        Console.WriteLine("Insert string {0}", randomString.Insert(10, "starting "));
        Console.WriteLine("Replace string {0}", randomString.Replace("string", "sentence"));
        Console.WriteLine("Compare String A to A {0}", String.Compare("A", "A", StringComparison.OrdinalIgnoreCase));

        Console.WriteLine("------------------");
        Console.WriteLine("Equal String A to a {0}", String.Equals("a", "A", StringComparison.OrdinalIgnoreCase));
        Console.WriteLine("Pad Left {0}", randomString.PadLeft(20, '.'));
        Console.WriteLine("Pad Right {0}", randomString.PadRight(20, '.'));
        Console.WriteLine("Trim {0}", randomString.Trim());
        Console.WriteLine("UpperCase {0}", randomString.ToUpper());
        Console.WriteLine("LowerCase {0}", randomString.ToLower());

        string newString = String.Format("{0} saw a {1} {2} in the {3}", "Paul", "Rabit", "eating", "field");
        Console.Write(newString + "\n");
        Console.WriteLine(@"It prints the escapce \n as it is");
    }
    public void FormattingOutput()
    {
        Console.WriteLine($"The value {4.55} in currency is {4.55:C}");
        Console.WriteLine($"The value {4} padded with 0s is {4:d4}");
        Console.WriteLine($"The value {4.5556} padded with 3 decimals is {4.5556:f3}");
        Console.WriteLine($"The value {4500} with commas is {4500:n4}");
    }
    public void ArrayBasics()
    {
        int[] favNums = new int[3];
        favNums[0] = 10;
        string[] customers = { "Ram", "Sam", "Ham" };
        var employees = new[] { "Emp1", "Emp2", "Emp3" };
        object[] randomArray = { "String", 12, 1.2 };
        Console.WriteLine("The 0th elements in randomArray is {0}", randomArray[0].GetType());
        Console.WriteLine("The number of elements " + randomArray.Length);

        for (var i = 0; i < employees.Length; i++)
        {
            Console.WriteLine($"Array Index : {i} Array Element : {employees[i]}");
        }

        Console.WriteLine("Multi Dimensional Array");
        string[,] godNames = new string[2, 2] { { "Ram", "Krishna" }, { "Sita", "Radha" } };
        Console.WriteLine($"{godNames[0, 0]} loves {godNames[1, 0]}");
        Console.WriteLine($"{godNames.GetValue(0, 1)} loves {godNames.GetValue(1, 1)}");

        for (int i = 0; i < godNames.GetLength(0); i++)
        {
            for (int j = 0; j < godNames.GetLength(0); j++)
            {
                Console.WriteLine("{0} ", godNames[i, j]);
            }
            Console.WriteLine();
        }
    }
    public void PrintArray(int[] intArray)
    {
        foreach (int i in intArray)
        {
            Console.Write($"{i}    ");
        }
        Console.WriteLine();
    }
    public void ArrayFunction()
    {
        int[] randNums = { 1, 9, 4, 11, 5 };
        Console.WriteLine("Before Sorting");
        PrintArray(randNums);

        Array.Sort(randNums);
        Console.WriteLine("After Sorting");
        PrintArray(randNums);

        //Get the value at a index
        Console.WriteLine("Index of 1 in randNums is {0}", Array.IndexOf(randNums, 1));

        //Insert new value at a index
        randNums.SetValue(7, 4);

        int[] destArray = new int[randNums.Length];
        Array.Copy(randNums, destArray, randNums.Length);
        PrintArray(destArray);

        //Another way to create an Array
        Array newArr = Array.CreateInstance(typeof(int), randNums.Length);
        randNums.CopyTo(newArr, 0);
        Console.WriteLine("newArr created using Array.CreateInstance()");

        string st1 = "derek";
        string st2 = "DEREK";
        Console.WriteLine($"{st1.Equals(st2, StringComparison.OrdinalIgnoreCase)}");
    }
    public void RandomNumber()
    {
        Random rand = new Random();
        int secretNumber = rand.Next(1, 11);
        int numberGuessed = 0;
        do
        {
            Console.WriteLine("Enter a guess number between 1 and 10");
            numberGuessed = Convert.ToInt32(Console.ReadLine());

        } while (secretNumber != numberGuessed);
        Console.WriteLine("You nailed it, the secret number was {0}", secretNumber);
    }
    static int DoDivision(int x, int y)
    {
        if (y == 0)
            throw new System.DivideByZeroException();
        return x / y;
    }
    public void ExceptionBasics()
    {
        int num1 = 5;
        int num2 = 0;
        try
        {
            Console.WriteLine($"{num1} / {num2} is {DoDivision(num1, num2)}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Cannot divide by zero. The divisor can't be 0");
            Console.WriteLine(ex.GetType().Name);
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Closing the exception");
        }
    }
    public void StringBuilderDemo()
    {
        StringBuilder sb1 = new StringBuilder("My name is khan", 256);
        Console.WriteLine($"Capacity : {sb1.Capacity}");
        Console.WriteLine($"Length : {sb1.Length}");
        sb1.AppendLine("\n And I am not a Terrorist");
        CultureInfo enUs = CultureInfo.CreateSpecificCulture("en-US");
        string myName = "Shah Rukh Khan";
        sb1.AppendFormat(enUs, $"My name is {myName}");
        Console.WriteLine(sb1.ToString());
        Console.WriteLine($"{sb1.Clear()} After clearing, {sb1}");

        sb1.Append("My name is Ranbir Kapoor");
        int introLength = sb1.Length;
        Console.WriteLine(sb1.Equals("ANIMAL"));
        sb1.Insert(introLength, "I am a ANIMAL");
        Console.WriteLine($"The new string is {sb1.ToString()}");
        sb1.Remove(introLength, "I am a Animal".Length);
        Console.WriteLine($"The old string is {sb1}");
    }

    public static void PrintInfo(string name, int zipCode)
    {
        Console.WriteLine("Name is {0} and zipCode is {1}", name, zipCode);
    }
    public void NamedParameterDemo()
    {
        PrintInfo(zipCode: 1234, name: "Prajanya");
    }

    public static double GetSum(double x = 2.2, double y = 2.2)
    {
        return x + y;
    }
    public static double GetSum(string x = "2.2", string y = "2.2")
    {
        double dblX = Convert.ToDouble(x);
        double dblY = Convert.ToDouble(y);
        return dblX + dblY;
    }
    public void MethodOverloadingDemo()
    {
        Console.WriteLine("The sum is {0}", GetSum(2.2, 2.2));
        Console.WriteLine("The sum is {0}", GetSum("2.2", "2.2"));
    }

    public void DateTimeDemo()
    {
        DateTime birthDate = new DateTime(1999, 8, 7);
        Console.WriteLine("Day of the week {0}", birthDate.DayOfWeek);
        birthDate.AddDays(7);
        birthDate.AddMonths(1);
        birthDate.AddYears(1);
        Console.WriteLine("New Date : {0}", birthDate.Date);
    }
    enum CarColor : byte
    {
        Red = 1,
        Green,
        Blue,
        Orange

    }

    static void PaintCar(CarColor cc)
    {
        Console.WriteLine("The car was painted {0} with code {1}", cc, (int)cc);
    }
    public void enumDemo()
    {
        CarColor cc = CarColor.Red;
        PaintCar(cc);
    }

    struct Rectangle
    {
        public double length;
        public double breadth;

        public Rectangle(double l = 1, double b = 1)
        {
            length = l;
            breadth = b;
        }
        public double Area()
        {
            return length * breadth;
        }
    }
    static void Main(String[] args)
    {
        Rectangle rect1;
        rect1.length = 200;
        rect1.breadth = 100;
        Console.WriteLine("The Area is {0} ", rect1.Area());
        Rectangle rect2 = new Rectangle(100, 50);
        rect2 = rect1;
        rect1.length = 100;
        Console.WriteLine("The length of rect2 is {0}", rect2.length);
    }

}