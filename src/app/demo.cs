
class Demo
{
    static void Main(string[] args)
    {
        Console.WriteLine("Demo class is running.");
        var employee = new Employee("John Doe", 30, "Software Engineer");
        employee.DisplayInfo();

    }
}


class Employee
{

    public string Name { get; set; }
    public int Age { get; set; }
    public string Role { get; set; }
    public Employee(string name, int age, string role)
    {
        Name = name;
        Age = age;
        Role = role;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Employee Name: {Name}, Age: {Age}, Role: {Role}");
    }
}