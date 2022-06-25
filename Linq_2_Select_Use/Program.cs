using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_2_Select_Use
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> lst_emp = new List<Employee>
            {
                new Employee{ Id = 101,Email="manish@gmail.com",Name = "Manish"},
                new Employee{ Id = 102,Email="sara@gmail.com",Name = "Sara"},
                new Employee{ Id = 103,Email="josh@gmail.com",Name = "Josh"},
                new Employee{ Id = 104,Email="neha@gmail.com",Name = "Neha"},
                new Employee{ Id = 105,Email="luv@gmail.com",Name = "luv"}
            };


            var newlist = new List<Employee> { new Employee { Id = 106, Email = "avdesh@gmail.com", Name = "avdesh" } };
            lst_emp.AddRange(newlist);


            var result = lst_emp.Select(x => x.Id.ToString()).ToList();
            var result1 = lst_emp.Select(x => x.Name).ToList();

            //in this result name will be null for all employee
            var rsl_emp = lst_emp.Select(x => new Employee { Id = x.Id, Email = x.Email + "_" + x.Name }).ToList();


            //converting emloyee result to student class
            var rsl_emp_to_student = lst_emp.Select(x => new Student { Id = x.Id, Name = x.Email + "_" + x.Name }).ToList();


            //converting employee data to anonymous form
            var rsl_emp_to_anonymous = lst_emp.Select(x => new { Id = x.Id, Name = x.Email + "_" + x.Name }).ToList();

            var rsl_emp_to_anonymous_with_index = lst_emp.Select((x,iindex) => new {Index= iindex ,Id = x.Id, Name = x.Email + "_" + x.Name }).ToList();

            foreach (var item in rsl_emp_to_anonymous_with_index)
            {
                //index will become 0,1,2,....
                Console.WriteLine("Id : = "+item.Id + " Email and Name : = "+item.Name + " Index : = " + item.Index);
            }
            Console.ReadLine();

        }
    }
}
