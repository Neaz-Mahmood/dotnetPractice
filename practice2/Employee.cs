    public class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name, decimal salary)

        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Employee name cannot be null or empty.");

            Name = name;
            Salary = salary;
        }
    }