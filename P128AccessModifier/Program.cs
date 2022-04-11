using System;

namespace P128AccessModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Char Methods
            //string test = "Salam1#23";

            //char symbol = test[7];

            //bool check = char.IsDigit(symbol);

            //Console.WriteLine(check);

            //if (char.IsSymbol(symbol))
            //{
            //    Console.WriteLine("Reqemdir");
            //}
            //else if (char.IsUpper(symbol))
            //{
            //    Console.WriteLine("Boyuk Herifdir");
            //}
            //else if (char.IsLower(symbol))
            //{
            //    Console.WriteLine("Kicik Herifdir");
            //}
            //else if (char.IsNumber(symbol))
            //{
            //    Console.WriteLine("Simvoldur");
            //}
            //else
            //{
            //    Console.WriteLine("Duzgun Deyil");
            //}

            //string test = "Sala;$№m1+#23";

            //int countLower = 0;
            //int countDigit = 0;
            //int countSymbol = 0;
            //int countSeperator = 0;

            //foreach (char item in test)
            //{
            //    if (char.IsLower(item))
            //    {
            //        countLower++;
            //    }
            //    else if (char.IsDigit(item))
            //    {
            //        countDigit++;
            //    }else if (char.IsSymbol(item))
            //    {
            //        countSymbol++;
            //    }
            //    else if (char.IsSeparator(item))
            //    {
            //        countSeperator++;
            //    }
            //}

            //Console.WriteLine($"Kicik Herfden Bu {countLower} {countSeperator} Qederdir, reqemdende Bu {countDigit} qederdir, symboldan bu {countSymbol} qederdir");

            //int a = 0;

            //char letter = test[1];

            //if (char.IsLower(letter))
            //{
            //    Console.WriteLine($"{char.ToUpper('1')}");
            //}
            #endregion

            #region Access Modifier
            //Human human = new Human("Test",15);

            //human.Name = "";

            //Console.WriteLine(human.Name);
            //string test = human.Name;

            //human.SetAge(13);
            //Console.WriteLine(human.GetAge());
            //human.SetAge(66);
            //Console.WriteLine(human.GetAge());
            //human.SetAge(56);
            //Console.WriteLine(human.GetAge());

            //human.SetBirthYear(1966);
            //Console.WriteLine(human.GetBirthYear());

            //Set Process
            //human.Age = 56;
            ////Get Process
            //Console.WriteLine(human.Age);
            ////Set Process
            //human.BirthYear = 1966;
            ////Get Process
            //int a = human.BirthYear;
            //Console.WriteLine(human.BirthYear);
            //Console.WriteLine(a);

            Human human = new Human("Test", 15, 13, 1966);
            human.Age = 14;
            human.BirthYear = 1966;
            human.FatherName = "Filankes";
            Console.WriteLine(human.Info());
            Console.WriteLine(human.FatherName);

            Student student = new Student("Test", 15, 13, 1966);
            student.Grade = 81;
            Console.WriteLine(student.Info());

            #endregion
        }
    }
}
