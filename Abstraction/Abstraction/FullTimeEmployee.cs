using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class FullTimeEmployee:BaseEmployee
    {
        public string employeePosition { get; set; }
        public string employeeDepartment { get; set; }
        public FullTimeEmployee(string id, string name, string address, string position, string department) 
            : base(id, name, address) 
        {
            this.employeePosition = position;
            this.employeeDepartment = department;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Position: {employeePosition}\nDepartment: {employeeDepartment}");
        }
        public override double CalculateSalary(int workingHours)
        {
            return 250 + workingHours*10.80;
        }
        public override string GetDepartment()
        {
            return employeeDepartment;
        }
    }
}
