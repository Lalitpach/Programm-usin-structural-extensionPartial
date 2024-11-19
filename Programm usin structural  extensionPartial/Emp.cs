using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programm_usin_structural__extensionPartial
{
    internal class Add
    {
        public enum Department { HR = 1, Sales, Dev, Testing, Admin }

        public enum Roles { Emp = 100, Manager = 200, CEO = 300, HRManager = 400 }
        public class Emp
        {
            private int id;
            private string name;
            private Department dept;
            private Roles roles;

            public Emp(int id, string name, Department dept, Roles roles)
            {
                this.id = id;
                this.name = name;
                this.dept = dept;
                this.roles = roles;
            }

            public override string ToString()
            {
                return $"{id}, {name} , {dept} ";
            }
        }



        static void Main(string[] args)
        {
            Emp e = new Emp(101, "Lalit", Department.Dev, Roles.Manager);
            Console.WriteLine(e);

        }
    }
}
