
internal class Program
{
    private static void Main(string[] args)
    {

        /*  Console.WriteLine("Password Checker.....!");
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
          }*/
        //odd and even list
        /* List<int> odd = new List<int>();
         List<int> even = new List<int>();
         bool end = true;
         Console.WriteLine("Press '0' key to End");
         while (end) { 
             int num = Convert.ToInt32(Console.ReadLine());
             if(num == 0)
             {
                 end = false;
             }

             else if (num % 2 == 0) { 
                 even.Add(num);
             }
             else
             {
                 odd.Add(num);
             }

         }
         Console.WriteLine("Odd numbers");
         foreach (int num in odd) {
             Console.Write(num+" ");
         }
         Console.WriteLine("\nEven numbers");
         foreach (int num in even) { Console.Write(num + " "); }*/
        /* Console.WriteLine("Calculating Area of the Triangele");
         Console.WriteLine("Enter the base of the Triangle");
         int baseOfT = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Enter the Height of the Triangle");
         int height = Convert.ToInt32(Console.ReadLine());
         calculateAreaOfTriangle(baseOfT, height);*/
        //sum of int array
        /*  int[] arr = new int[] {};
          int res = sumOfIntArray(arr);
          if (res <= -1)
          {
              Console.WriteLine("Empty Array");
          }
          else {Console.WriteLine(res); }*/
        //Prime number program in C#
        Console.WriteLine("Enter the to check whether it's a prime number or not");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(isPrime(num)); 
        
    }

    private static bool isPrime(int num)
    {
        if (num <= 1)
        {
            return false;
        }
        else if (num <= 3) {
            return true;
        }
        for (int i = 2; i <= num / 2; i++) { 
            if(num%i == 0)
            {
                return false;
            }
        }
        return true;
    }

    private static int sumOfIntArray(int[] arr)
    {   
        if(arr.Length == 0)
        {
            return -1;
        }
        int sum = 0;
        foreach (int i in arr) { 
            sum += i;
        }
        return sum;
    }

    private static void calculateAreaOfTriangle(int baseOfT, int height)
    {
        Console.WriteLine($"Area of Triangle is: {(baseOfT * height)/2}");
    }
}