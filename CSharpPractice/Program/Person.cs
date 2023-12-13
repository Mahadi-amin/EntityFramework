using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAdvance
{
    public abstract class Person 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        protected int[] grades;

        public string Id
        {
            get { return GetId();  }
        }

        public Person(int size)
        {
            grades = new int[size];
        }
        ~Person()
        {
            grades = new int[0];
        }
        public void GetNmae(int[] grade)
        {
            this.grades = grade;
        }
        public abstract string GetId();
    }
}
