using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter a number: ");
        string number = Console.ReadLine();

        try // Attempt to parse the input as an integer
        { int num = int.Parse(number); // This line may throw a FormatException if the input is not a valid integer
            Console.WriteLine($"You entered numbered as: {number}"); // Output the entered number
        }
        catch (FormatException ex) // Catch block for handling format exceptions
        {
            Console.WriteLine("Error: Number format is invalid. Please enter a number."); // Inform the user about the format error
        }
        catch (Exception ex) // Catch block for handling any other exceptions that may occur
        {
            Console.WriteLine($"Unexpected error: "+ ex.Message); // Inform the user about an unexpected error
        }
        finally // Finally block that executes regardless of whether an exception was thrown or not
        {
            Console.WriteLine("Thank you for using the program."); // Inform the user that the program is ending
        }
    }
}