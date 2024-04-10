// Yiping He 04/10/2024

// Practice working with Generics

using Assignment_0410;

Student s1 = new Student(1, "xx");
Student s2 = new Student(2, "xxx");
Student s3 = new Student(3, "xxxx");

// Test MyStack
MyStack<Student> myStack = new MyStack<Student>();
myStack.Push(s1);
myStack.Push(s2);
myStack.Push(s3);
// should be xx, xxx, xxxx now
Console.WriteLine($"Current stack size: {myStack.Count()}");
Console.WriteLine($"Popping first item: {myStack.Pop().Name}"); // xxxx
Console.WriteLine($"Popping second item: {myStack.Pop().Name}");    // xxx
Console.WriteLine($"Popping third item: {myStack.Pop().Name}"); // xx
Console.WriteLine($"Current stack size: {myStack.Count()}");

// Test MyList
MyList<Student> myList = new MyList<Student>();
myList.Add(s1);
myList.Add(s2);
myList.InsertAt(s3, 1);
myList.DeleteAt(2);
// should be xx, xxxx now
Console.WriteLine($"Removing first item: {myList.Remove(0).Name}"); // xx
Console.WriteLine($"Removing second item: {myList.Remove(0).Name}");    // xxxx

// Test GenericRepository
GenericRepository<Student> genericRepository = new GenericRepository<Student>();
genericRepository.Add(s1);
genericRepository.Add(s2);
genericRepository.Add(s3);
genericRepository.Remove(s2);
// should be xx, xxxx now
IEnumerable<Student> students= genericRepository.GetAll();
Console.WriteLine("Current repository:");
foreach (Student student in students)
{
    Console.WriteLine(student.Name);
}
Console.WriteLine($"Getting item with id = 3: {genericRepository.GetById(3).Name}"); // xx
