using System;

public class Class1
{
	static void Main()
	{
        string strChoice;
        int TotalAmount = 0;
        do
        {
            Console.WriteLine("Which coffee would you like to buy? 1.Small 2.Medium 3.Large");
            int choice = int.Parse(Console.ReadLine().ToUpper());
            switch (choice)
            {
                case 1:
                    TotalAmount += 1;
                    break;
                case 2:
                    TotalAmount += 2; break;
                case 3:
                    TotalAmount += 3; break;
                default:
                    Console.WriteLine("Invalid coffee choice {0}. Choice must be 1, 2 or 3", choice);
                    break;
            }
            do
            {
                Console.WriteLine("Do you want to buy another coffee? Yes or No");
                strChoice = Console.ReadLine().ToUpper();
                if (strChoice != "YES" && strChoice != "NO")
                    Console.WriteLine("Invalid choice {0}. Say yes or no !", strChoice);
            } while (strChoice != "YES" && strChoice != "NO");
        } while (strChoice == "YES");
        Console.WriteLine("Your Bill Amount is {0}", TotalAmount);
    }
}
