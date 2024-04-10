namespace Assignment_0409;

public class Instructor : Person, IInstructorService
{
    public Department Department { get; set; }
    public DateTime JoinDate { get; set; }
    public decimal Bonus;

    public Instructor(string name, DateTime birthday) : base(name, birthday)
    {
    }

    public Instructor(string name, DateTime birthday, decimal salary) : base(name, birthday, salary)
    {
    }

    public void JoinDepartment(Department department, DateTime joinDate, decimal bonus)
    {
        JoinDate = joinDate;
        Department = department;
        Bonus = bonus;
    }

    public decimal CalculateBonusSalary()
    {
        int yearsOfExperience = (int)((DateTime.Now - JoinDate).TotalDays / 365);
        return Salary + yearsOfExperience * Bonus; 
    }
}
