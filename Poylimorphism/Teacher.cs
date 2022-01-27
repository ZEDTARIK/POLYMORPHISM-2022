using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poylimorphism
{
    public class Teacher : Employee
    {
        public string? EmployeePosition { get; set; }

        public void setValue(int Id, string Name, double Salary, string position)
        {
            EmployeeId = Id;
            EmployeeName = Name;
            EmployeeSalary = Salary;
            EmployeePosition = position;
        }
        public string getValues()
        {
            string text = "EmployeeId: "+ EmployeeId + Environment.NewLine;
            text += "EmployeeName: " + EmployeeName  + Environment.NewLine;
            text += "Employee Salary:  "+ EmployeeSalary + Environment.NewLine;
            text += "Employee Position: "+ EmployeePosition  + Environment.NewLine;
            return text;
        }
    }
}
