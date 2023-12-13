using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        protected int[] grades;

        public string Id
        {
            get { return GetId(); }
        }
        public Person(int size)
        {
            grades = new int[size];
        }
        ~Person()
        {
            grades = new int[0];
        }

        public void SetGrades(int[] grades)
        {
            this.grades = grades;
        }
        public abstract string GetId();
    }
}
