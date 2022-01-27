using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poylimorphism
{
    public class Employee2
    {
        public int EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public double EmployeeSalary { get; set; }
        public string? EmployeePosition { get; set; }

        public virtual string  setValues(int Id, string Name, double Salary)
        {
            EmployeeId = Id;
            EmployeeName = Name;
            EmployeeSalary = Salary;

            string text = "EmployeeId: " + EmployeeId + Environment.NewLine;
            text += "EmployeeName: " + EmployeeName + Environment.NewLine;
            text += "Employee Salary:  " + EmployeeSalary + Environment.NewLine;
            return text;
        }
    }
}
