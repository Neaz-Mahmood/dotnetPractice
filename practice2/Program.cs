// See https://aka.ms/new-console-template for more information
    EmployeeDirectory employeeDirectory = new EmployeeDirectory();


        try
        {
            employeeDirectory.DisplayMinMaxSalaries();
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }