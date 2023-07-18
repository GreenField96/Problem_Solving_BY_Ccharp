//using System.Text;
using helloAppCcharp;

internal class Program{
    public delegate void drinkAction();
    public static int num = 1000;
    private static void Main(string[] args) {

        var emps = new Employee[] {
            new Employee("ahemd",2000),
            new Employee("ali",3000),
            new Employee("jamal",4000),
            new Employee("sofian",4200),
            new Employee("said",800) ,
            new Employee("sami",5200) ,
            new Employee("yassin",10300) 
        };
     
     var rep = new Report();

     rep.printReport(emps, "employess have salary grater than 1000", isGreterThanthousnd);

     rep.printReport(emps,"employess have salary grater than 2000", (Employee emp) => emp.getSalary() > 2000);
     
     rep.printReport(emps, "employess have salary grater than 3000 & smaller than 5000", emp => emp.getSalary() > 3000 & emp.getSalary() < 5000 );

    }
    public static bool isGreterThanthousnd(Employee emp) => emp.getSalary() > 1000;
}

public class Report{
    public delegate bool numOfSalaryfun(Employee emp);
    public void printReport(Employee[] emps, String title, numOfSalaryfun numOfSalary)
    {
        Console.WriteLine(title);
        Console.WriteLine("********************************");
        foreach (Employee emp in emps)
        {
            if (numOfSalary(emp))
            {
                Console.WriteLine("emp;loyee name : " + emp.getName());
            }
        }
        Console.WriteLine("********************************");
    }
}
