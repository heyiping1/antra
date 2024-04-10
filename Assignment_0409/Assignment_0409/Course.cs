namespace Assignment_0409;

public class Course
{
    public string Name { get; set; }
    public List<Student> EnrolledStudents { get; set; }

    public Course(string name)
    {
        Name = name;
        EnrolledStudents = new List<Student>();
    }

    public void EnrollStudent(Student student)
    {
        EnrolledStudents.Add(student);
    }

    public List<Student> GetStudents()
    {
        return EnrolledStudents;
    }
}
