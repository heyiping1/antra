// Yiping He 04/09/2024

using Assignment_0409;

// Working with methods

// 1. Reverse Generator
Console.WriteLine("Test: Reverse Generator");
ReverseGenerator.Main([]);

// 2. Fibonacci Numbers
Console.WriteLine("Test: Fibonacci Numbers");
FibonacciNumbers.Main([]);


// Designing and building classes using object-oriented principles

// 1. Person
Console.WriteLine("Test: Person");
Person person1 = new Person("xx", new DateTime(2000, 1, 27), 1000000);
Person person2 = new Person("xxx", new DateTime(2023, 8, 26));
person1.AddAddress("sd");
person2.AddAddress("china");
person2.AddAddress("united state");
Console.WriteLine($"Person1: name = {person1.Name}, age = {person1.CalculateAge()}, salary = {person1.CalculateSalary()}, addresses = {string.Join(", ", person1.GetAddresses())}");
Console.WriteLine($"Person1: name = {person2.Name}, age = {person2.CalculateAge()}, salary = {person2.CalculateSalary()}, addresses = {string.Join(", ", person2.GetAddresses())}");

// 2. Instructor
Console.WriteLine("Test: Instructor");
Instructor instructor1 = new Instructor("xx", new DateTime(2000, 1, 27), 1000000);
Instructor instructor2 = new Instructor("hyp", new DateTime(2000, 1, 1));
instructor1.JoinDepartment(new Department("cs"), new DateTime(2022, 5, 20), 50000);
Console.WriteLine($"Instructor1: name = {instructor1.Name}, age = {instructor1.CalculateAge()}, base salary = {instructor1.CalculateSalary()}, bonus salary = {instructor1.CalculateBonusSalary()}");
Console.WriteLine($"Instructor2: name = {instructor2.Name}, age = {instructor2.CalculateAge()}, base salary = {instructor2.CalculateSalary()}, bonus salary = {instructor2.CalculateBonusSalary()}");

// 3. Student
Console.WriteLine("Test: Student");
Student student1 = new Student("xx", new DateTime(2000, 1, 27));
Student student2 = new Student("hyp", new DateTime(2000, 1, 1));
student1.AddCourseGrade("cs400", 'A');
student2.AddCourseGrade("cs300", 'C');
student2.AddCourseGrade("cs400", 'B');
Console.WriteLine($"Student1: name = {student1.Name}, gpa = {student1.CalculateGPA()}");
Console.WriteLine($"Student2: name = {student2.Name}, gpa = {student2.CalculateGPA()}");

// 4. Course
Console.WriteLine("Test: Course");
Course course1 = new Course("cs300");
Course course2 = new Course("cs400");
course1.EnrollStudent(student2);
course2.EnrollStudent(student1);
course2.EnrollStudent(student2);
Console.WriteLine($"Course1: name = {course1.Name}, enrolled students = {string.Join(", ", course1.GetStudents())}");
Console.WriteLine($"Course2: name = {course2.Name}, enrolled students = {string.Join(", ", course2.GetStudents())}");

// 5. Department
Console.WriteLine("Test: Department");
Department department = new Department("cs");
department.SetHead(instructor1);
department.SetBudget(50000, new DateTime(2023, 6, 29), new DateTime(2024, 6, 29));
Console.WriteLine($"Department: name = {department.Name}, head = {department.Head.Name}, budget = {department.Budget}, start date = {department.StartDate}, end date = {department.EndDate}");

// 6. Color
Console.WriteLine("Test: Color");
Color color1 = new Color(100, 0, 0, 0);
Color color2 = new Color(50, 33, 100);
color2.Green = 90;
Console.WriteLine($"Color1: red = {color1.Red}, green = {color1.Green}, blue = {color1.Blue}, grayscale = {color1.getGrayScale()}");
Console.WriteLine($"Color2: red = {color2.Red}, green = {color2.Green}, blue = {color2.Blue}, grayscale = {color2.getGrayScale()}");

// 7. Ball
Console.WriteLine("Test: Ball");
Ball ball1 = new Ball(10, color1);
Ball ball2 = new Ball(15, color2);
Ball ball3 = new Ball(20, 50, 30, 40, 50);
ball1.Throw();
ball2.Throw();
ball2.Throw();
ball3.Throw();
ball3.Throw();
ball3.Throw();
ball2.Pop();
ball2.Throw();
Console.WriteLine($"Ball1: size = {ball1.Size}, thrown count = {ball1.getThrownCount()}");
Console.WriteLine($"Ball2: size = {ball2.Size}, thrown count = {ball2.getThrownCount()}");
Console.WriteLine($"Ball3: size = {ball3.Size}, thrown count = {ball3.getThrownCount()}");
