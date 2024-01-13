




using System.Globalization;
using exercicios_5.Entities;

List<Employee> employe = new List<Employee>();



Console.Write("Enter the number of employees: ");
int n = int.Parse(Console.ReadLine());


for(int count = 1; count <= n; count++)
{
    Console.WriteLine($"Employee #{count} data:");
    Console.Write("Outsourced (y/n)? ");
    char type = char.Parse(Console.ReadLine());

    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Hours: ");
    int hours = int.Parse(Console.ReadLine());
    Console.Write("Value per hour: ");
    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


    if(type == 'y')
    {
        Console.Write("Additional charge: ");
        double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        employe.Add(new OutSourcedEmployee(name, hours, valuePerHour, additionalCharge));
    }
    else
    {
        employe.Add(new Employee(name, hours, valuePerHour));
    }
}


Console.WriteLine("PAYMENTS:");

foreach(Employee emp in employe)
{
    Console.WriteLine(emp);
}
