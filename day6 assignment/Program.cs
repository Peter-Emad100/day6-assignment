namespace day6_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*List <Customer> customers = new List<Customer>() {
                new Customer() { Name = "ahmad", Email = "gg@g", Phone = "00000" },
                new Customer() { Name = "joke", Email = "joke@g", Phone = "00000" },
                new Customer() { Name = "doke", Email = "doke@g", Phone = "00000" },
                new Customer() { Name = "poke", Email = "poke@g", Phone = "00000" },
                new Customer() { Name = "coke", Email = "gg@g", Phone = "00000" }
            };*/
            /*PerformActionOnCustomers(customers , somefunc); */
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){Name="yaya",Exp=10, Salary=1000},
                 new Employee(){Name="lala",Exp=5, Salary=100},
                  new Employee(){Name="rara",Exp=30, Salary=10000},
                   new Employee(){Name="caca",Exp=3, Salary=888},
                    new Employee(){Name="uaua",Exp=9, Salary=10090}
            };
            /*SortEmployees(employees, comparison);
            Console.WriteLine("Sorted array: " + string.Join(", ", employees));*/
            CalculateBonus(employees, e => e.Exp * e.Salary * 0.009);

        }
        public static void PerformActionOnCustomers(List<Customer> customers, Action<Customer> action)
        {
            for(int i=0; i<customers.Count; i++)
            {
                action(customers[i]);
            }
        }
        public static void somefunc(Customer c)
        {
            Console.WriteLine($"name = {c.Name} email = {c.Email} phone = {c.Phone}");
            Console.WriteLine($"email was sent to {c.Email}");
        }

        public static void SortEmployees(List<Employee> emps, Func<Employee, Employee, int> comparison)
        {
            for(int i=1; i < emps.Count; i++)
            {
                Employee current = emps[i];
                int j = i - 1;
                
                while(j>=0 && comparison(emps[j], current) == 1)
                {
                    emps[j + 1] = emps[j];
                    j--;
                }
                emps[j + 1] = current;
            }
            
        }
        public static int comparison(Employee e,Employee e2 ) {
            if (e.Salary > e2.Salary)
            {
                 return 1;
            }
            else if (e.Salary < e2.Salary)
            {
                return -1;
            }
            else { return 0; }

        }
         public static void CalculateBonus(List<Employee> employees, Func<Employee, double> bonusCalculator)
        {
            for(int i=0; i < employees.Count; i++)
            {
                Console.WriteLine($"{employees[i].Name} {employees[i].Exp} {bonusCalculator(employees[i])}");
            }
        }
        
    }
}
