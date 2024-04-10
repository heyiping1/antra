namespace Assignment_0409;

public interface IDepartmentService
{
    void SetHead(Instructor instructor);
    void SetBudget(decimal budget, DateTime startDate, DateTime endDate);
}
