using System;

namespace PolymorphismStudy
{
    public class Teacher:Employee
    {
        public string EmployeePosition { get; set; }

        public void SetValues(int ID, string EmployeeName, double Salary, string position)
        {
            EmployeeID = ID;
            Name = EmployeeName;
            EmployeeSalary = Salary;
            EmployeePosition = position;
        }

        public string GetValues()
        {
            string text = "Employee ID: " + EmployeeID + Environment.NewLine;
            text += "Employee Name: " + Name + Environment.NewLine;
            text += "Employee Salary: " + EmployeeSalary + Environment.NewLine;
            text += "Employe Position: " + EmployeePosition + Environment.NewLine;
            return text;
        }
    }
}
