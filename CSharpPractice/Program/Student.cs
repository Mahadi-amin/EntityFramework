using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace OOPAdvance
{
    public class Student : Person, IPerson
    {
        private const string _idPrefix = "ST-";
        private readonly int _id;
        private string address;
        public Student(int id) : base(100)
        {
            _id = id;
        }
        public double CalculateCgpa()
        {
            var cgpa = 2.5;
            foreach (var c in grades)
            {
                cgpa += c;
            }
            return cgpa / grades.Length;
        }

        public override string GetId()
        {
            return _idPrefix + _id;
        }

        public void SetAddress(string address)
        {
            this.address = address;
        }

        public void Talk(string message)
        {
            Console.WriteLine(message);
        }
    }
}
