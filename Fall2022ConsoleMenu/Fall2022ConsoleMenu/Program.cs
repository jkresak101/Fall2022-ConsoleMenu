//Setup and welcome
using System.Runtime.InteropServices; // idk what this is

Console.WriteLine("Welcome To The BEST and MOST Complicated Application Ever Coded!!");
var isRunning = true;
//App-Loop
while (isRunning)
{
    // present our user some options
    Console.WriteLine("What would you like to do today? type the number of the action youd like to preform");
    Console.WriteLine("1.Quit Application \n2. Live Recording ");
    switch (Console.ReadLine())
    {
        case "1":
            //act based on the option they chose
            isRunning = false;
            break;
        case "2":
            Console.Clear();
            
            Console.WriteLine("GEEEEZ");
            Console.Beep();
            
            Console.WriteLine("Press Enter To Continue");
            Console.ReadLine();
            break;
            default :
            Console.WriteLine("I Dont Understand");
            break;
    }

}

// user has quit application
Console.Clear();
Console.WriteLine("Goodbye!");