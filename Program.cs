using System.Buffers;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using System.Collections;

namespace Deniston
{
    class Program
    {
        #region Find Odd \ Even

        //static void Main(string[] args)
        //{
        //    Console.Write("Enter a number : ");
        //    string number = Console.ReadLine() ?? string.Empty;
        //    int num = int.Parse(number);

        //    if (num % 2 == 0) { Console.Write("the Number is Even"); }

        //    else { Console.Write("the Number is Odd"); }
        //}

        #endregion

        #region Advanced Odd Or Even

        //static void Main(string[] args)
        //{
        //    string Number = Console.ReadLine() ?? string.Empty;
        //    string[] num = Number.Split(' ');

        //    FindOddOrEven(num);
        //}


        //static void FindOddOrEven(string[] args)
        //{
        //    foreach (var arg in args)
        //    {
        //        if (int.TryParse(arg, out int number))
        //        {
        //            Console.WriteLine($"{number} is " + (number % 2 == 0 ? "Even" : "Odd"));
        //        }
        //        else
        //        {
        //            Console.WriteLine($"{arg} is not a valid number.");
        //        }
        //    }
        //}

        #endregion

        #region Find Polindrome

        /*static void Main()
        {
            string input = "kook";
            bool poly = IsPoly(input);
            Console.WriteLine("IS this polindrome " + poly);
        }
        static bool IsPoly(string Do)
        {
            Do = Do.ToLower();
            Do = Regex.Replace(Do, @"[^a-z0-9]", "");
            char[] deni = Do.ToCharArray();
            Array.Reverse(deni);
            string Re = new string(deni);
            return Do == Re;
        }*/
        #endregion

        #region Prime Number

        //static void Main(string[] args)
        //{
        //    for (int i = 1; i <= 100; i++)
        //    {
        //        bool IsPrime = true;
        //        for (int j = 2; j <= Math.Sqrt (i); j++)
        //        {
        //            if (i % j == 0)
        //            {
        //                IsPrime = false;
        //                break;
        //            }
        //        }

        //        if (IsPrime)
        //        {
        //            Console.Write(i + "\t");
        //        }
        //    }
        //}

        #endregion

        #region Find Digits

        //static void Main(string[] args)
        //{
        //    string Number = Console.ReadLine() ?? string.Empty;
        //    int num = int.Parse(Number);
        //    int attempt = 0;
        //    while (num != 0)
        //    {
        //        attempt++;
        //        num = num / 10;
        //    }

        //    Console.WriteLine(" {0} is {1} digits number", Number,attempt);
        //}

        #endregion

        #region Do While 

        //static void Main(string[] args)
        //{
        //    string CorrectPin = "1234";
        //    int count = 0;
        //    string pin;

        //    do { pin = Console.ReadLine() ?? string.Empty; count++; }

        //    while (CorrectPin != pin & count < 3);

        //    if (pin == CorrectPin)
        //    { Console.WriteLine("Welcome Deni....!"); }
        //    else
        //    { Console.WriteLine("incorrect Pin"); }

        //}

        #endregion

        #region Learning How To Input For all Data Types

        /*
         static void Main(string[] args)
         {
             // For String
             string Name = Console.ReadLine() ?? string.Empty;

             // For Int
             int number = int.Parse(Console.ReadLine() ?? string.Empty);

             // For Bool
             bool MySpeech = bool.Parse(Console.ReadLine() ?? bool.TrueString);

             // For String Array
             string Items = Console.ReadLine() ?? string.Empty;
             string[] Canteen = Items.Split(',');
             foreach (string item in Canteen)
             { Console.WriteLine(item); }

             // For Different Sized String Array

             string[] Deni = new string[2];
             for (int i = 0; i < Deni.Length; i++)
             {
                 Console.WriteLine($"add no{i + 1} :");
                 Deni[i] = Console.ReadLine() ?? string.Empty;
             }
             foreach (string member in Deni)
             { Console.WriteLine("your members  :" + member); }

         }
        */

        #endregion

        #region Arrays

        #region Single Dimension Array

        //static void Main(string[] args)
        //{
        ////----------------type one

        //int[] arr = new int[] { 10, 20, 30, 40 };

        //for (int i = 0; i < arr.Length; i++)
        //{
        //    Console.WriteLine(arr[i]);
        //}

        ////----------------type two

        //int[] arr = new int[4];
        //arr[0] = 10; arr[1] = 20; arr[2] = 30; arr[3] = 50;

        //foreach (int item in arr)
        //{
        //    Console.Write(item+"\t");
        //}

        ////----------Sort Order For Searching

        //int[] IdCard = new int[] { 59, 15, 36, 60 ,14 };

        //for (int i = 0; i < IdCard.Length -1; i++)
        //{
        //    for (int Role = 0; Role > IdCard.Length -1; Role++)
        //    {
        //        if (IdCard[Role] < IdCard[Role + 1])
        //        {
        //            int Temp = IdCard[Role];
        //            IdCard[Role] = IdCard[Role + 1];
        //            IdCard[Role + 1] = Temp;
        //        }
        //    }
        //}

        //foreach (int item in IdCard)
        //{ Console.Write(item + "\t" ); }

        //}
        #endregion

        #region Multi Dimension Array

        //static void Main(string[] args)
        //{
        //    int[,] arr = new int[2, 3] { { 10, 20, 30 }, { 40, 50, 60 } };

        //    for (int i = 0; i < 2; i++)
        //    {
        //        for (int j = 0; j < 3; j++)
        //        {
        //            Console.Write(arr[i,j] + "\t");
        //        }
        //    }

        //}


        #endregion

        #region Jagged Array

        //static void Main(string[] args)
        //{
        //    int[][] Multiverse = new int[3][];
        //    Multiverse[0] = new int[] { 1, 2, 3, 4 };
        //    Multiverse[1] = new int[] { 10,20 };
        //    Multiverse[2] = new int[] { 100, 200, 300, 400 };

        //    foreach (int[] arr in Multiverse)
        //    {
        //        foreach (int item in arr)
        //        {
        //            Console.Write(item + "\t");
        //        }
        //        Console.Write("\n");
        //    }

        //}

        #endregion

        #endregion

        #region String Builder

        //static void Main(string[] args)
        //{
        //    string Deni = "";
        //    StringBuilder sd =new StringBuilder(Deni);
        //    sd.Append("goT APPOINTMENT");

        //    sd.Append(" ALSO THANKS");

        //    Console.WriteLine(sd);
        //}
        #endregion

        #region Object Initializer / Constructors

        /*
        int Age;
        string? Name;  //Object Initializer
        static int Century;

        Program()     //Default Constructor
        {
            Age = 23;
            Name = "Kiran";
        }

        Program(int age ,string name)   //Parameterized Constructor
        { 
            this.Name= name;    
            this.Age = age;
        }

        static Program()    //static Constructor
        {
            Century= 100;
        }

        void Trick()
        {
            Console.Write(" Name :" + Name + "\n Age :" + Age +"\n");
            int DoB = 2024 - Age;
            Console.WriteLine("{0}'s Date of Birth is " + DoB , Name);
            Console.WriteLine("Life Span Years :"+ Century);
        }

        static void Main(string[] args)
        {
            Program deni = new Program { Age = 22, Name = "Deniston" }; 
            deni.Trick();
            Program kiran = new Program();
            kiran.Trick();
            Program P2 = new Program(15,"Essak");
            P2.Trick();
            Program P3 = kiran;         // Copy Constructor
            P3.Trick();
            Deni Do = new Deni();
        }


        */

        #endregion

        #region Stream Reader

        //static void Main()
        //{
        //    string startupPath = AppDomain.CurrentDomain.BaseDirectory; //prints Current Project Directory

        //    using (StreamReader sr = new StreamReader(Path.Combine(startupPath, "Bio.txt"))) 
        //    {
        //        string? Line = sr.ReadLine();
        //        Console.WriteLine(Path.Combine(startupPath, "Bio.txt"));
        //        Console.WriteLine(Line);
        //        ArrayList ArrList = new ArrayList();
        //        ArrList.Add(Line);
        //        Console.WriteLine(ArrList[0]);
        //    }
        //}
        #endregion
    }

    #region New Class

    class Deni 
    {
        private void Name()
        {
            Console.WriteLine("Deniston");
        }

        public void Age()
        {
            Console.WriteLine("23");
        }

        internal void Blood()
        {
            Console.WriteLine("O +ve");
        }

        protected void Intro()
        {
            Console.WriteLine("i am deni");
        }
    }

    class Dinesh : Deni 
    {
        public new void Intro()             //New Keyword Used for Data Hiding 
        {
            Console.WriteLine("i am dinesh");
        }
    }

    class Subbu : Dinesh
    {
        public new void Intro()
        {
            Console.WriteLine("i am Subbu");
        }
    }

    class Jeya
    {
        //static void Main(string[] args)
        //{
        //    Deni D1 = new Deni();

        //}
    }

    #endregion

    #region Property

    class Gomma
    {
        private int ada;

        public int Gommala
        {
            set
            {
                if (value > 100)
                {
                    Console.WriteLine("adangommala");
                    return;
                }
                ada = value;
            }
            get { return ada; }
        }

        Gomma()
        {
            this.Gommala = 100;
        }

        //static void Main(string[] args)
        //{
        //    Gomma Go = new Gomma();
        //    Console.WriteLine(Go.Gommala);
        //}
    }

    #endregion

    #region enumeration

    class Practice
    {
        enum Week
        { 
            Monday,
            Tuesday, 
            Wednesday,
            Thursday, 
            Friday,
            Saturday, 
            Sunday
        }

        static void Main(string[] args)
        {
            int week = (int)Week.Wednesday;
            Console.WriteLine(week);

            Week W1 = Week.Monday;
            switch (W1) 
            {
                case Week.Monday:
                    Console.WriteLine("First Day of the Work");
                    break;
                case Week.Tuesday:
                    Console.WriteLine("Second Day of the Work");
                    break;
                case Week.Sunday:
                    Console.WriteLine("Last Day of the Work");
                    break;
            }
        }
    }

    #endregion


}


