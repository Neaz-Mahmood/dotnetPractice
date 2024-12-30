Assignment assignment = new Assignment("homework 1", new DateTime(2020, 12, 31), new List<string> { "Task 1", "Task 2" }, new List<string> { "Resource 1", "Resource 2" });
assignment.SubmitHomework("Alice");
assignment.SubmitHomework("Bob");
assignment.GradeHomework("Alice", "A");
assignment.GradeHomework("Bob", "B");
Console.WriteLine(assignment.GetGrade("Alice")); // Output: A
Console.WriteLine(assignment.GetGrade("Bob")); // Output: B
Console.WriteLine(assignment.GetGrade("Charlie")); // Output: Not graded

