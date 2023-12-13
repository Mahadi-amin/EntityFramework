using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Student : Person
    {
        private const string _idPrefix = "S-";
        private readonly int _id;
        public Student(int id) : base(100)
        {
            _id = id;
        }

        public double CalculateCgpa()
        {
            var cgpa = 0;
            foreach (var item in grades)
            {
                cgpa += item;
            }
            return cgpa;
        }

        public override string GetId()
        {
            return _idPrefix + _id;
        }
    }      
}
