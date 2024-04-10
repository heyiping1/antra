namespace Assignment_0410;

public class Student : Entity
{
    public string Name { get; set; }
    public double Grade {  get; set; }

    public Student(int id, string name) : base(id)
    {
        Name = name;
    }
}
