//Names: Aidan Singh and Dante Martin Verdecie
//Date: 11-09-2025
using System;
using System.Collections.Generic;

public class GradeSystem
{
    public static void Main(string[] args)
    {
        // Create a dictionary to store prizes with integer keys
        Dictionary<int, string> prize = new Dictionary<int, string>
        {
            {0, "iPhone 15"},      // Key 0 maps to iPhone 15
            {1, "AirPods Pro 3"}   // Key 1 maps to AirPods Pro 3
        };
        
        // Display the initial dictionary contents using an enumerator
        IEnumerator<KeyValuePair<int, string>> enumerator = prize.GetEnumerator();
        while (enumerator.MoveNext())
        {
            KeyValuePair<int, string> pair = enumerator.Current;
            Console.WriteLine($"Key: {pair.Key}, Item: {pair.Value}");
        }
        enumerator.Dispose(); // Dispose the enumerator to free resources
        
        // Ask the user to input a grade
        Console.Write("Enter a grade: ");
        int grade = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine();

        // Switch statement based on the grade to determine actions
        switch(grade)
        {
            // Case for grades 90 and above
            case int x when x >= 90:
                Console.WriteLine("You get an additional prize!");
                
                // Loop to ensure the user enters a unique key
                bool key_exists = true;
                int key = 0;
                while(key_exists)
                {
                    Console.Write("Insert a new key: ");
                    key = Convert.ToInt32(Console.ReadLine());
                    if(prize.ContainsKey(key))
                    {
                        key_exists = true;  // Key exists, ask again
                    }
                    else 
                    {
                        key_exists = false; // Key is unique, exit loop
                    }
                }

                // Ask user to insert the new prize for the unique key
                Console.Write("Insert a new prize: ");
                string new_prize = Console.ReadLine();
                prize.Add(key, new_prize); // Add new key-value pair to dictionary
                break;

            // Case for grades between 80 and 89
            case int x when x >= 80:
                Console.WriteLine("You get to change one prize!");
                key_exists = false;
                key = 0;

                // Loop until the user enters a valid existing key
                while(!key_exists)
                {
                    Console.Write("Choose the key of a prize you want to remove: ");
                    key = Convert.ToInt32(Console.ReadLine());
                    if(prize.ContainsKey(key))
                    {
                        key_exists = true; // Key exists, proceed
                    }
                    else 
                    {
                        key_exists = false; // Invalid key, ask again
                    }
                }

                // Replace the existing prize with the user-selected prize
                Console.Write("Select the prize of your choosing: ");
                string user_prize = Console.ReadLine();
                prize[key] = user_prize; 
                break;

            // Case for grades between 70 and 79
            case int x when x >= 70:
                Console.WriteLine("You can only get one prize!");
                key_exists = false;
                key = 0;

                // Loop until the user enters a valid existing key
                while(!key_exists)
                {
                    Console.Write("Choose the key of a prize you want to remove: ");
                    key = Convert.ToInt32(Console.ReadLine());
                    if(prize.ContainsKey(key))
                    {
                        key_exists = true; // Key exists, proceed
                    }
                    else 
                    {
                        key_exists = false; // Invalid key, ask again
                    }
                }

                // Remove the chosen prize from the dictionary
                prize.Remove(key);
                break;

            // Default case for grades below 70
            default:
                Console.WriteLine("You get nothing!");
                prize.Clear(); // Clear all prizes
                break;
        }

        Console.WriteLine();

        // Convert the dictionary to a SortedDictionary to sort by keys
        SortedDictionary<int, string> sortedPrize = new SortedDictionary<int, string>(prize);

        // Display the sorted dictionary using an enumerator
        IEnumerator<KeyValuePair<int, string>> enumerator2 = sortedPrize.GetEnumerator();
        while (enumerator2.MoveNext())
        {
            KeyValuePair<int, string> pair = enumerator2.Current;
            Console.WriteLine($"Key: {pair.Key}, Item: {pair.Value}");
        }
        enumerator2.Dispose(); // Dispose enumerator
    }
}
