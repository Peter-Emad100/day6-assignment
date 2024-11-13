using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6_assignment
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Exp {  get; set; }
        public int Salary {  get; set; }
        public override string ToString()
        {
            return $"{Name} {Exp} {Salary}";
        }
    }
}
