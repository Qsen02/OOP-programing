namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee("38sadkasdjf21", "Pesho", "Burgas,Bulgaria", "unknown", "misterious");
            ContractEmployee contractor = new ContractEmployee("fdgj34ksdfsjd", "Gosho", "Sofia,Bulgaria", "Very important task", "special");

            fullTimeEmployee.Show();
            Console.WriteLine($"Full time salary: {fullTimeEmployee.CalculateSalary(40)}");
            Console.WriteLine(fullTimeEmployee.GetDepartment());

            contractor.Show();
            Console.WriteLine($"Contractor salary: {contractor.CalculateSalary(40)}");
            Console.WriteLine(contractor.GetDepartment());
        }
    }
}
