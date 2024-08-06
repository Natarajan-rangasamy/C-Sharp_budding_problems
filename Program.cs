internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Password Checker.....!");
        Console.WriteLine("Enter the password.....");
        string ep = Console.ReadLine();
        while (ep.Length == 0) {
            Console.WriteLine("Please enter some text null values not allowed.........");
            ep = Console.ReadLine();
        }
        Console.WriteLine("Please confirm your password again!");
        string cp= Console.ReadLine();
        while (cp.Length == 0) {
            Console.WriteLine("Please enter some text null values not allowed.........");
            cp = Console.ReadLine();
        }
        bool check = true;
        while (check)
        {
            if (ep.Equals(cp))
            {
                Console.WriteLine("All done Your password has been set");
                check = false;
            }
            else
            {
                Console.WriteLine("Password Mismatch!\nEnter the password again");
                cp = Console.ReadLine();
            }
        }

    }
}