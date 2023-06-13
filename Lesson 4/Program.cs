using System.Globalization;

namespace Lesson_4
{

    class Program
    {
        static void charCount(string st)
        {
            
            int[] charCounts = new int[128];
            int max = charCounts[0];
            int maxChar = 0;
            string str = "";
            foreach (var item in st)
            {
                charCounts[item]++;
            }
            for (int i = 0; i < charCounts.Length; i++)
            {
                if (charCounts[i] > 0)
                {
                    Console.WriteLine($"{(char)i}={charCounts[i]}");
                    if (charCounts[i] > max)
                    {
                        max = charCounts[i];
                        maxChar = (char)i;
                        str += (char)i;

                    }
                    else if (charCounts[i] == max)
                    {
                        str += (char)i;
                    }
                }

            }
            for (int j = 0; j < str.Length; j++)
            {
                Console.WriteLine($"Max {str[j]}={max}");
            }
        }
        enum DayTime
        {
            Morning,
            Afternoon,
            Evening,
            Night
        }

        public static void MyColors(int c)
        {
            if (c>=0 && c<=3)
            {
                switch (c)
                {
                    case (int)Colors.Red:
                        Console.WriteLine(Colors.Red);
                        break;
                    case (int)Colors.Blue:
                        Console.WriteLine(Colors.Blue);
                        break;
                    case (int)Colors.Green:
                        Console.WriteLine(Colors.Green);
                        break;
                    case (int)Colors.Black:
                        Console.WriteLine(Colors.Black);
                        break;
                }

            }
        }
        enum DaysOfWeek
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7
        }

        enum Colors
        {
            Red,
            Green,
            Blue,
            Black
        }

        static void Rec(int a)
        {
            if (a > 0)
            {
                Console.WriteLine("Barev");
                a--;
                Rec(a);
            }
            else
                return;
        }
      
        static void Increment(ref int value)
        {
            value++;
        }

        static void ChangeY(out int y)

        {

            y = 100;

            Console.WriteLine("y IN function " + y);

        }

        static void ChangeX(ref int x)

        {

            x = 100;

            Console.WriteLine("x IN function " + x);

        }

        static void Sum (int a,int b, out int sum)
        {
            sum = a + b;
        }

        static int fact(int n)
        {
            
            if (n<=1)
            {
                return 1;
            }
            return n * fact(n - 1);
        }

        static int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static void changePlaces(ref int x,ref int y)
        {
            int z = x;
            x = y;
            y= z;
        }

        static int Sum(int n)
        {
           
            if(n==1)
                return 1;
            
            return n + Sum(n - 1);

        }

        static void ashxatavardziHashvich(ref decimal ashxatavardz,  decimal ekamtahark,
            decimal socialakanVchar, decimal droshmavchar, string tt)
        {

            if (tt=="tt")
            {
                ekamtahark = 10;
            }
            ekamtahark = ashxatavardz * (ekamtahark / 100);
            ashxatavardz -= ekamtahark + socialakanVchar + droshmavchar;
            
        }

        static void FooIn(in string a)
        {
            Console.WriteLine(a);
        }

        static int fooArray(int[] arr, int i = 0) 
        {
            if (i >= arr.Length)
                return 0;

            return arr[i] + fooArray(arr, i + 1);
      
        }

        static void Main(string[] args)
        {



            charCount("sadasdsfsdfsdfsdfsdasda");


            string str = "aaaallllyryrtyryu";
            int[] charCounts = new int[128];
            int max = charCounts[0];
            int maxChar = 0;
            string st = "";
            foreach (var item in str)
            {
                charCounts[item]++;
            }
            for (int i = 0; i < charCounts.Length; i++)
            {
                if (charCounts[i] > 0)
                {
                    Console.WriteLine($"{(char)i}={charCounts[i]}");
                    if (charCounts[i] > max)
                    {
                        max = charCounts[i];
                        maxChar = (char)i;
                        st += (char)i;

                    }
                    else if (charCounts[i] == max)
                    {
                        st += (char)i;
                    }
                }

            }
            for (int j = 0; j < st.Length; j++)
            {
                Console.WriteLine($"Max {st[j]}={max}");
            }




            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(fooArray(myArray));

            decimal ashxatavardz = 100000;
            decimal ekamtahark = 20;
            decimal socialakanVchar = 5000;
            decimal droshmavchar = 1500;

            Console.WriteLine("Ashxatavardz: " + ashxatavardz);

            ashxatavardziHashvich(ref ashxatavardz, ekamtahark, socialakanVchar, droshmavchar, "tt");


            Console.WriteLine("Maqur Mnacord: " + ashxatavardz);



            Console.WriteLine(Sum(5));

            int num1 = 45;
            int num2 = 14;
            Console.WriteLine($"Num1={num1}  Num2={num2}");
            changePlaces(ref num1, ref num2);
            Console.WriteLine($"Num1={num1}  Num2={num2}");

            Console.WriteLine(Fibonacci(6));

            Console.WriteLine(fact(5));
            int x = 5;

            ChangeX(ref x);

            Console.WriteLine("x OUT function " + x);



            int y;

            ChangeY(out y);

            Console.WriteLine("y OUT function " + y);



            int number = 5;
            Increment(ref number);
            Console.WriteLine(number);


            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int sum = 0;
            Sum(a, b, out sum);
            Console.WriteLine(sum);

            FooIn("Hello");

            Rec(5);

            DaysOfWeek day = DaysOfWeek.Wednesday;
            int dayNumber = (int)day;
            Console.WriteLine(dayNumber);

            int color = int.Parse(Console.ReadLine());

            switch (color)
            {
                case (int)Colors.Red:
                    Console.WriteLine(Colors.Red);
                    break;
                case (int)Colors.Blue:
                    Console.WriteLine(Colors.Blue);
                    break;
                case (int)Colors.Green:
                    Console.WriteLine(Colors.Green);
                    break;
                case (int)Colors.Black:
                    Console.WriteLine(Colors.Black);
                    break;

            }

            MyColors(0);

            int dayTime = int.Parse(Console.ReadLine());

            switch (dayTime)
            {
                case (int)DayTime.Morning:
                    Console.WriteLine("Good Morning");
                    break;
                case (int)DayTime.Evening:
                    Console.WriteLine("Good Evening");
                    break;
                case (int)DayTime.Night:
                    Console.WriteLine("Good Night");
                    break;
                case (int)DayTime.Afternoon:
                    Console.WriteLine("Good Afternoon");
                    break;

            }


        }
    }
}