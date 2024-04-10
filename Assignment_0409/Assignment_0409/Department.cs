namespace Assignment_0409;

public class Department : IDepartmentService
{
    public string Name { get; set; }
    public Instructor Head { get; set; }
    public decimal Budget { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public List<Course> Courses { get; set; }

    public Department(string name)
    {
        Name = name;
        Courses = new List<Course>();
    }

    public void SetHead(Instructor instructor)
    {
        Head = instructor;
    }

    public void SetBudget(decimal budget, DateTime startDate, DateTime endDate)
    {
        Budget = budget;
        StartDate = startDate;
        EndDate = endDate;
    }

    public void OfferCourse(Course course)
    {
        Courses.Add(course);
    }

    public List<Course> GetCourses()
    {
        return Courses;
    }
}
