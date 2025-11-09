using System;
using System.Collections.Generic;

public class GradePrizes
{
    public static void Main(string[] args)
    {
        Dictionary<int, string> prize = new Dictionary<int, string>
        {
            {0, "iPhone 15"},
            {1, "AirPods Pro 3"}
        };
        
        IEnumerator<KeyValuePair<int, string>> enumerator = prize.GetEnumerator();
        while (enumerator.MoveNext())
        {
            KeyValuePair<int, string> pair = enumerator.Current;
            Console.WriteLine($"Key: {pair.Key}, Item: {pair.Value}");
        }
        enumerator.Dispose();
        
        Console.Write("Enter a grade: ");
        int grade = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine();
        switch(grade)
        {
            case int x when x >= 90:
                Console.WriteLine("You get an additional prize!");
                bool key_exists = true;
                int key = 0;
                while(key_exists)
                {
                    Console.Write("Insert a new key: ");
                    key = Convert.ToInt32(Console.ReadLine());
                    if(prize.ContainsKey(key))
                    {
                        key_exists = true;
                    }
                    else 
                    {
                        key_exists = false;
                    }
                }
                Console.Write("Insert a new prize: ");
                string new_prize = Console.ReadLine();
                prize.Add(key, new_prize);
                break;
            case int x when x >= 80:
                Console.WriteLine("You get to change one prize!");
                key_exists = false;
                key = 0;
                while(!key_exists)
                {
                    Console.Write("Choose the key of a prize you want to remove: ");
                    key = Convert.ToInt32(Console.ReadLine());
                    if(prize.ContainsKey(key))
                    {
                        key_exists = true;
                    }
                    else 
                    {
                        key_exists = false;
                    }
                }
                Console.Write("Select the prize of your choosing: ");
                string user_prize = Console.ReadLine();
                prize[key] = user_prize;
                break;
            case int x when x >= 70:
                Console.WriteLine("You can only get one prize!");
                key_exists = false;
                key = 0;
                while(!key_exists)
                {
                    Console.Write("Choose the key of a prize you want to remove: ");
                    key = Convert.ToInt32(Console.ReadLine());
                    if(prize.ContainsKey(key))
                    {
                        key_exists = true;
                    }
                    else 
                    {
                        key_exists = false;
                    }
                }
                prize.Remove(key);
                break;
            default:
                Console.WriteLine("You get nothing!");
                prize.Clear();
                break;
        }
        Console.WriteLine();
        
        SortedDictionary<int, string> sortedPrize = new SortedDictionary<int, string>(prize);

        IEnumerator<KeyValuePair<int, string>> enumerator2 = sortedPrize.GetEnumerator();
        while (enumerator2.MoveNext())
        {
            KeyValuePair<int, string> pair = enumerator2.Current;
            Console.WriteLine($"Key: {pair.Key}, Item: {pair.Value}");
        }
        enumerator2.Dispose();
    }
}
