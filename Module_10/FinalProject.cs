//Names: Aidan Singh and Dante Martin Verdecie
//Date: 11-30-2025
using System;

public class Contractor
{
  private string name;
  private int number;
  private DateTime startDate;
  
  public Contractor()
  {
    name = "Billy Bob";
    number = 1;
    startDate = DateTime.Now;
  }
  public Contractor(string n, int num, DateTime date)
  {
    name = n;
    number = num;
    startDate = date;
  }

  public string Name
  {
    get {return name;}
    set {name = value;}
  }
  public int Number
  {
    get {return number;}
    set {number = value;}
  }
  public DateTime StartDate
  {
    get {return startDate;}
    set {startDate = value;}
  }
}


public class SubContractor : Contractor
{
  private int shift;
  private double hourlyPayRate;

  public SubContractor() 
  {
    shift = 1;
    hourlyPayRate = 15.00;
  }
  public SubContractor(int s, double pay)
  {
    shift = s;
    hourlyPayRate = pay;
  }
  public SubContractor(string n, int num, DateTime date, int s, double pay)
  {
    Name = n;
    Number = num;
    StartDate = date;
    shift = s;
    hourlyPayRate = pay;
  }

  public int Shift
  {
    get {return shift;}
  }
  public double HourlyPayRate
  {
    get {return hourlyPayRate;}
  }
}


public class Project
{
  public static float ComputePay(SubContractor sub, double payRate)
  {
    if(sub.Shift == 2) 
    {
      return (float)payRate * 1.03f;
    }
    return (float)payRate;
  }
  public static void Main(string[] args)
  {
    Console.WriteLine("Here is your first contractor:");
    SubContractor sub = new SubContractor("John Doe", 1, new DateTime(2025, 12, 1), 2, 25.00);
    double pay = ComputePay(sub, sub.HourlyPayRate);
    Console.WriteLine($"Name: {sub.Name}");
    Console.WriteLine($"Number: {sub.Number}");
    Console.WriteLine($"Start Date: {sub.StartDate}");
    Console.WriteLine($"Shift: {sub.Shift}");
    Console.WriteLine($"Hourly Pay Rate: ${pay}");
    Console.WriteLine();

    Console.WriteLine("How many more contractors do you want to add?");
    string numContractorsStr = Console.ReadLine();
    int numContractors = Convert.ToInt32(numContractorsStr);
    Console.WriteLine();

    SubContractor[] contractors = new SubContractor[numContractors];
    int number = 1;
    for(int i = 0; i < numContractors; i++)
    {
      Console.WriteLine("Enter the name of the contractor:");
      string name = Console.ReadLine();
      
      number++;
      
      Console.WriteLine("Enter the start year of the contractor:");
      string yearStr = Console.ReadLine();
      int year = Convert.ToInt32(yearStr);

      Console.WriteLine("Enter the start month of the contractor:");
      string monthStr = Console.ReadLine();
      int month = Convert.ToInt32(monthStr);

      Console.WriteLine("Enter the start day of the contractor:");
      string dayStr = Console.ReadLine();
      int day = Convert.ToInt32(dayStr);

      Console.WriteLine("Enter the shift of the contractor (1 or 2):");
      string shiftStr = Console.ReadLine();
      int shift = Convert.ToInt32(shiftStr);

      Console.WriteLine("Enter the hourly pay rate of the contractor:");
      string payRateStr = Console.ReadLine();
      double payRate = Convert.ToDouble(payRateStr);
    
      SubContractor temp = new SubContractor(name, number, new DateTime(year, month, day), shift, payRate);
  
      double hrPayRate = ComputePay(temp, payRate);
      contractors[i] = new SubContractor(name, number, new DateTime(year, month, day), shift, hrPayRate);
      
      Console.WriteLine();
    }

    foreach(SubContractor contractor in contractors) 
    {
      Console.WriteLine($"Name: {contractor.Name}");
      Console.WriteLine($"Number: {contractor.Number}");
      Console.WriteLine($"Start Date: {contractor.StartDate}");
      Console.WriteLine($"Shift: {contractor.Shift}");
      Console.WriteLine($"Hourly Pay Rate: ${contractor.HourlyPayRate:F2}");
      Console.WriteLine();
    }
  }
}
