namespace ClassAndAccessModifiers;
class Program
{
    static void Main(string[] args)
    {
        /* class ClassName
        {
            [Access Modifiers] [Data Type] PropertyName;

            [Access Modifiers] [Return Type] MethodName ([Parameters])
            {
                
            }
        }
        */

        /* Access Modifiers
            * Public
            * Private
            * Internal
            * Protected
        */

        Employee employee1 = new();
        employee1.Name = "Bedirhan";
        employee1.Surname = "Siyam";
        employee1.Number = 56594875;
        employee1.Occupation = "Engineer";

        employee1.EmployeeInfos();

        Console.WriteLine("**********");
        
        Employee employee2 = new();
        employee2.Name = "Cengizhan";
        employee2.Surname = "Siyam";
        employee2.Number = 25654148;
        employee2.Occupation = "Director";

        employee2.EmployeeInfos();

    }
}

class Employee
{
    public string Name;
    public string Surname;
    public int Number;
    public string Occupation;

    public void EmployeeInfos()
    {
        Console.WriteLine("Employee name : " + Name);
        Console.WriteLine("Employee surname : " + Surname);
        Console.WriteLine("Employee number : " + Number);
        Console.WriteLine("Employee occupation : " + Occupation);
    }
}
