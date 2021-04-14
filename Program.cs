using System;

namespace NestedRepetition
{
    class Program
    {
        static void Main(string[] args)
        {
        //             Exercises 1
        // Create algorithms and desk checks for the following (flowcharts and/or pseudocode):
        // A program receives a user's name and prints it 10 times on the same line. This process happens 10 times.
        // A program receives a user's name and prints it for the amount of times that the user specifies.
        
        string userNumberString;
        int userNumber;
        
        Console.Write("enter name ");
        string userName = Console.ReadLine();
        for(int i = 0; i < 10; i++){
            Console.Write(userName + " ");
        }
        Console.WriteLine();
        Console.Write("enter name ");
        userName = Console.ReadLine();
        Console.Write("enter number ");
        userNumberString = Console.ReadLine();
        while(!int.TryParse(userNumberString, out userNumber))
            {
                Console.Write("Sorry, I didn't understand that, please enter whole number as a numeral: ");
                userNumberString = Console.ReadLine();
            }
        for(int i2 = 0; i2 < userNumber; i2++){
            Console.Write(userName+" ");
        }
        Console.WriteLine();
        

        // Exercises 2
        // For the following exercises the programs can only contain two output statements. Each to be used once.

        // PRINT x - Console.Write("x");
        // PRINT newline - Console.WriteLine();
        // The result of a program looks like:
        // xxxxx
        // xxxx
        // xxx
        // xx
        // x   
        int counter1;
        int counter2;
        
        for(counter1 = 0; counter1 < 5; counter1++){
            for(counter2 = 0; counter2 < 5 - counter1; counter2++){
                // PRINT x - Console.Write("x");
                Console.Write("x");
            }
            // PRINT newline - Console.WriteLine();
            Console.WriteLine();
        }

        // As above, but the user is able to enter the amount of starting x's

        Console.Write("enter number ");
        userNumberString = Console.ReadLine();
        while(!int.TryParse(userNumberString, out userNumber))
            {
                Console.Write("Sorry, I didn't understand that, please enter whole number as a numeral: ");
                userNumberString = Console.ReadLine();
            }
        for(counter1 = 0; counter1 < userNumber; counter1++){
            for(counter2 = 0; counter2 < userNumber - counter1; counter2++){
                // PRINT x - Console.Write("x");
                Console.Write("x");
            }
            // PRINT newline - Console.WriteLine();
            Console.WriteLine();
        }

        // The result of a program looks like:

        // x
        // xx
        // xxx
        // xxxx
        // xxxxx
        for(counter1 = 0; counter1 < 5; counter1++){
            for(counter2 = 0; counter2 < counter1 + 1; counter2++){
                // PRINT x - Console.Write("x");
                Console.Write("x");
            }
            // PRINT newline - Console.WriteLine();
            Console.WriteLine();
        }
        
        // As above, but the user is able to enter the amount of starting x's

        Console.Write("enter number ");
        userNumberString = Console.ReadLine();
        while(!int.TryParse(userNumberString, out userNumber))
            {
                Console.Write("Sorry, I didn't understand that, please enter whole number as a numeral: ");
                userNumberString = Console.ReadLine();
            }
        for(counter1 = userNumber-1; counter1 < 5; counter1++){
            for(counter2 = 0; counter2 < counter1+1; counter2++){
                // PRINT x - Console.Write("x");
                Console.Write("x");
            }
            // PRINT newline - Console.WriteLine();
            Console.WriteLine();
        }
        
        // Advanced Exercises (Optional)
        // For the following exercises the algorithms/programs may only contain three output statements. Each to be used once.

        // PRINT x
        // PRINT newline
        // PRINT " " (space)
        // Create the following outputs:

        // 1.

        // xxxxxxxxxxx
        //  xxxxxxxxx
        //   xxxxxxx
        //    xxxxx
        //     xxx
        //      x
        // 2.
        for(counter1 = 0; counter1 < 5; counter1++){
            // PRINT space - Console.Write(" ");
            for(counter2 = 0; counter2 < counter1; counter2++){
                Console.Write(" ");
            }
            for(counter2 = 0; counter2 < 2 * (5 - counter1) - 1; counter2++){
                // PRINT x - Console.Write("x");
                Console.Write("x");
            }
            // PRINT newline - Console.WriteLine();
            Console.WriteLine();
        }

        //      x
        //     xxx
        //    xxxxx
        //   xxxxxxx
        //  xxxxxxxxx
        // xxxxxxxxxxx
        Console.WriteLine("---");
        for(counter1 = 0; counter1 < 5; counter1++){
            // PRINT space - Console.Write(" ");
            for(counter2 = 0; counter2 < 5 - (counter1 + 1); counter2++){
                Console.Write(" ");
            }
            for(counter2 = 0; counter2 < 2 * (counter1 + 1) - 1; counter2++){
                // PRINT x - Console.Write("x");
                Console.Write("x");
            }
            // PRINT newline - Console.WriteLine();
            Console.WriteLine();
        }
        // 3. As above, but allow the user to enter the amount of lines.
        Console.Write("enter number ");
        userNumberString = Console.ReadLine();
        while(!int.TryParse(userNumberString, out userNumber))
            {
                Console.Write("Sorry, I didn't understand that, please enter whole number as a numeral: ");
                userNumberString = Console.ReadLine();
            }
            for(counter1 = 0; counter1 < userNumber; counter1++){
            // PRINT space - Console.Write(" ");
            for(counter2 = 0; counter2 < userNumber - (counter1 + 1); counter2++){
                Console.Write(" ");
            }
            for(counter2 = 0; counter2 < 2 * (counter1 + 1) - 1; counter2++){
                // PRINT x - Console.Write("x");
                Console.Write("x");
            }
            // PRINT newline - Console.WriteLine();
            Console.WriteLine();
        }


            Console.WriteLine("Hello World!");
        }
    }
}
