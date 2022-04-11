using System;
using System.Collections.Generic;
using System.Text;

namespace P128AccessModifier
{
    class Student : Human
    {
        public double Grade;
        public Student(string test, int result, byte age, int birthYEar) : base(test, result, age, birthYEar)
        {
            
        }

        public override string Info()
        {
            return $"{base.Info()}\nQiymet:{Grade}";
        }

        //public string Info()
        //{
        //    return $"Yas:{Age}\nDogum Ili:{BirthYear}\nQiymeti:{Grade}";
        //}
    }
}
