namespace Assignment_0409;

public class Student : Person, IStudentService {
    public Dictionary<string, char> Grades;

    public Student(string name, DateTime birthday) : base(name, birthday)
    {
        Grades = new Dictionary<string, char>();
    }

    public void AddCourseGrade(string course, char grade)
    {
        Grades.Add(course, grade);
    }

    public decimal CalculateGPA()
    {
        if (Grades.Count == 0)
        {
            return 0;
        }
        int points = 0;
        foreach (var grade in Grades.Values)
        {
            switch (grade)
            {
                case 'A':
                    points += 4;
                    break;
                case 'B':
                    points += 3;
                    break;
                case 'C':
                    points += 2;
                    break;
                case 'D':
                    points += 1;
                    break;
            }
        }
        return (decimal)points / Grades.Count;
    }
}
