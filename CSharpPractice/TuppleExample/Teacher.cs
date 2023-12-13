using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Teacher : Person
    {
        private const string _idPrefix = "T-";
        private readonly int _id = 0;
        public int Salary { get; set; }
        public Teacher(int id) : base(0)
        {
            _id = id;
        }

        public int CalculateBonus(int percent)
        {
            return Salary * percent / 100;
        }

        public override string GetId()
        {
            throw new NotImplementedException();
        }
    }
}
