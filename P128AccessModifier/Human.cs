using System;
using System.Collections.Generic;
using System.Text;

namespace P128AccessModifier
{
    class Human /*: Test*/
    {
        //Access Modifier
        //Private -  All Class Memmber Default Access Modifier Private
        //Protected - Only Own Class And Inherited Class Can Be Use
        //Public - everywhere can be use
        //readonly - Only can set data own class constructor (only field)

        private readonly string Name;
        string SurName;
        //private field
        private byte _age;
        private int _birthYear;

        //Property - Encapsulation
        public byte Age 
        {
            get 
            {
                return _age;
            }
            set
            {
                if (value > 15 && value < 65)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("duzgun daxil et");
                }
            }
        }

        public string FatherName { get; set; }

        public int BirthYear
        {
            get
            {
                return _birthYear;
            }
            set
            {
                if ((DateTime.Now.Year - _age) == value)
                {
                    _birthYear = value;
                }
                else
                {
                    Console.WriteLine("Duzgun Daxil Et Dogum Ilini");
                }
            }
        }

        #region Old Encapsulation
        //public void SetBirthYear(int birthYear)
        //{
        //    if ((DateTime.Now.Year -_age) == birthYear)
        //    {
        //        _birthYear = birthYear;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Duzgun Daxil Et Dogum Ilini");
        //    }
        //}

        //public int GetBirthYear()
        //{
        //    return _birthYear;
        //}

        //public void SetAge(byte age)
        //{
        //    if (age > 15  && age < 65)
        //    {
        //        _age = age;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Duzgun Daxil Et");
        //    }
        //}

        //public byte GetAge()
        //{
        //    return _age;
        //}

        //public Human()
        //{

        //}
        #endregion

        public Human(string name, int test, byte age, int birthYear) /*: base(test)*/
        {
            Age = age;
            BirthYear = birthYear;
            //Name = name;

            //Console.WriteLine(Age);

            //FatherName = "filankes";

            //Console.WriteLine(FatherName);
        }

        //Polymorphisym
        public virtual string Info()
        {
            return $"Yas:{_age}\nDogum Ili:{_birthYear}";
        }
    }
}
