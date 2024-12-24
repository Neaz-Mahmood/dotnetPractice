using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class EmployeeDirectory
{
    private List<Employee> employees;

    public EmployeeDirectory()
    {
        employees = new List<Employee>();
        LoadEmployeesFromCsv("salarysheet.csv");
    }

    private void LoadEmployeesFromCsv(string filePath)
    {
        if (!File.Exists(filePath))
            throw new FileNotFoundException("The specified file was not found.", filePath);

        var lines = File.ReadAllLines(filePath);
        foreach (var line in lines.Skip(1)) // Skip header line
        {
            var values = line.Split(',');
            if (values.Length >= 2)
            {
                var employee = new Employee(values[0], decimal.Parse(values[1]));
                employees.Add(employee);
            }
        }
    }

    public void DisplayMinMaxSalaries()
    {
        if (employees.Count == 0)
        {
            Console.WriteLine("No employees found.");
            return;
        }

        var maxSalaryEmployee = employees.OrderByDescending(e => e.Salary).First();
        var minSalaryEmployee = employees.OrderBy(e => e.Salary).First();

        Console.WriteLine($"Max: {maxSalaryEmployee.Name}   {maxSalaryEmployee.Salary}");
        Console.WriteLine($"Min: {minSalaryEmployee.Name}    {minSalaryEmployee.Salary}");
    }
}
