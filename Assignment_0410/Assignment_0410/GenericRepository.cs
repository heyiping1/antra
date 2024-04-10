using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_0410;
public class GenericRepository<T> : IRepository<T> where T : Entity
{
    private List<T> items = new List<T>();

    public void Add(T item)
    {
        items.Add(item);
    }

    public void Remove(T item)
    {
        if (items.Contains(item))
        {
            items.Remove(item);
        }
    }

    public void Save()
    {
        Console.WriteLine("You should connect to a database to save your data");
    }

    public IEnumerable<T> GetAll()
    {
        return items;
    }

    public T GetById(int id)
    {
        foreach (T item in items)
        {
            if (item.Id.Equals(id))
            {
                return item;
            }
        }
        return default(T);
    }

}
