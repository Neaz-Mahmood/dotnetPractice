using System;
using System.Collections.Generic;

public class Assignment
{
    public string Name { get; set; } 
    public DateTime DueDate { get; set; }
    public List<string> Tasks { get; set; }
    public List<string> Resources { get; set; }
    private Dictionary<string, bool> Submissions { get; set; }
    private Dictionary<string, string> Grades { get; set; }

    public Assignment(string name, DateTime dueDate, List<string> tasks, List<string> resources)
    {
        Name = name;
        DueDate = dueDate;
        Tasks = tasks;
        Resources = resources;
        Submissions = new Dictionary<string, bool>();
        Grades = new Dictionary<string, string>();
    }

    public void SubmitHomework(string studentName)
    {
        if (!Submissions.ContainsKey(studentName))
        {
            Submissions[studentName] = true;
        }
    }

    public void GradeHomework(string studentName, string grade)
    {
        if (Submissions.ContainsKey(studentName) && Submissions[studentName])
        {
            Grades[studentName] = grade;
        }
    }

    public string GetGrade(string studentName)
    {
        if (Grades.ContainsKey(studentName))
        {
            return Grades[studentName];
        }
        return "Not graded";
    }
}
