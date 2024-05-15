/*
 * Progran.cs
 */
class Program {
    
    static int numberOfValues = 0;

    // Gets the number of values the user wants to enter
    public static void getNumberOfValues()
    {
        Console.WriteLine("Enter the number of Values : ");
        numberOfValues = Convert.ToInt32(Console.ReadLine());
    }

    // Gets the values from the user
    public static void getValues()
    {
        for (int i = 0; i < numberOfValues; ++i)
        {
            Console.WriteLine($"Enter value {i+1} : ");
            string userInput = Console.ReadLine();
            // calls the divisibility function
            divisibility(userInput);
        }
    }
    /*
     * Checks if a number is divisible by 3 or 5 or both
     * @param   : user entered number
     * @return  : The generated string  - Fizz; divisible by 3
                                        - Buzz; divisible by 5
                                        - FizzBuzz; divible by 15
     */
    static void divisibility(string userInput)
    {
        int value;
        if (int.TryParse(userInput, out value))
        {
            // Checks divisibility of 15 | 3 and 5
            if ( value % 3 == 0 && value % 5 == 0 )
                Console.WriteLine("FizzBuzz");

            // Checks divisibility of 3
            else if ( value % 3 == 0 )
                Console.WriteLine("Fizz");
            
            // Checks divisibility of 5
            else if ( value % 5 == 0 )
                Console.WriteLine("Buzz");
        
            else
            {
                Console.WriteLine($"Divided {value} by 3");
                Console.WriteLine($"Divided {value} by 5");
            }
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }
    }

    static void Main()
    {
        Program.getNumberOfValues();
        Program.getValues();
    }
}