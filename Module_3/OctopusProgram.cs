using System;

class Octopus
{
  string name;
  public int Age = 10;
  static readonly int legs = 8, eyes = 1;

  public string Name {get {return name;} set{name = value;}}
}

class GiantPacific : Octopus
{
    public GiantPacific(string n) 
    {
        Name = n;
    }
    public GiantPacific(string n, int a) 
    {
        Name = n;
        Age = a;
    }
}

public class Program
{
    public static void Main()
    {
        GiantPacific gp1 = new GiantPacific("Jeffrey");
        GiantPacific gp2 = new GiantPacific("Thomas", 4);
        
        if(gp1.Age > gp2.Age)
        {
            Console.WriteLine($"{gp1.Name} is older than {gp2.Name}");
        }
        else if(gp1.Age < gp2.Age)
        {
            Console.WriteLine($"{gp2.Name} is older than {gp1.Name}");
        }
        else 
        {
            Console.WriteLine($"{gp1.Name} and {gp2.Name} are the same age");
        }
    }
}
