namespace Assignment_0409;

public class Person : IPersonService
{
    public string Name { get; set; }
    public DateTime Birthday { get; set; }
    public decimal Salary { get; set; }
    public List<string> Addresses { get; set; }

    public Person(string name, DateTime birthday)
    {
        Name = name;
        Birthday = birthday;
        Salary = 0;
        Addresses = new List<string> { };
    }

    public Person(string name, DateTime birthday, decimal salary)
    {
        Name = name;
        Birthday = birthday;
        Salary = salary;
        Addresses = new List<string> { };
    }

    public int CalculateAge()
    {
        return (int)((DateTime.Now - Birthday).TotalDays / 365);
    }

    public decimal CalculateSalary()
    {
        if (Salary == 0)
        {
            return 0;
        }
        return Salary;
    }

    public void AddAddress(string address)
    {
        Addresses.Add(address);
    }

    public List<string> GetAddresses()
    {
        return Addresses;
    }

}
