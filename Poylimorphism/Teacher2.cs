using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poylimorphism
{
    public class Teacher2: Employee2
    {
        override public string setValues(int Id, string Name, double Salary)
        {
            EmployeeId = Id;
            EmployeeName = Name;
            EmployeeSalary = Salary;
            EmployeePosition = "Ovverid setValues";

            string text = "EmployeeId: " + EmployeeId + Environment.NewLine;
            text += "EmployeeName: " + EmployeeName + Environment.NewLine;
            text += "Employee Salary:  " + EmployeeSalary + Environment.NewLine;
            text += "Employee Position: " + EmployeePosition + Environment.NewLine;
            return text;
        }

    }
}
