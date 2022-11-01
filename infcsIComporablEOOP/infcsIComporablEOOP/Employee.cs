using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infcsIComporablEOOP
{
    public class Employee : IComparable
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Salary { get; set; }

        public int CompareTo(object? obj)
        {
            var other = (Employee)obj;

            if (this.Salary < other.Salary)
            {
                return -1;  
            }
            else if (this.Salary.Equals(other.Salary))
            {
                return 1;   
            }
            else
            {
                return 0;
            }



        }

        public override string ToString()
        {
            return $"{Id,-5} {FullName,-20 } {Salary,-7}";
        }
    }
}
