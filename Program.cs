//start main
DisplayMenu();
string userChoice= GetMenuChoice();
while (userChoice != "4"){
    RouteThem(userChoice);
    DisplayMenu();
    userChoice= GetMenuChoice();
}
//end main

static void DisplayMenu(){
   Console.Clear();
    System.Console.WriteLine(" 1. Display a plain topping-less pizza slice \n 2. Display cheese pizza slice \n 3. Display Pepperoni Pizza Slice \n 4.ExitMenu ");
}

static string GetMenuChoice(){
    System.Console.WriteLine("Enter your menu choice");
    return Console.ReadLine();
}

static void RouteThem(string userChoice){
    
    switch (userChoice){
        case "1":
            GetPlainPizza();
            break;
        case "2":
            GetCheesePizza();
            break;
        case "3":
            GetPepperoniPizza();
            break;
        case "4":
            SayGoodBye();
            break;
        default:
            System.Console.WriteLine("Invalid menu choice!!! Please select a valid menu choice");
            Pause();
            break;
    }
}

static void GetPlainPizza(){
    Random randomm = new Random();
    int rows = randomm.Next(8, 13); // Generates a random number of rows between 8 and 13
        
        System.Console.WriteLine("Here is your plain pizza slice, enjoy:");

    for (int i = rows; i > 0; i--) // Outer loop controls the rows
    {
        for (int j = 0; j < i; j++) // Inner loop prints the stars in each row
        {
            System.Console.Write(" * ");
        }
        System.Console.WriteLine(); // Move to the next line after each row
    }
    Pause();
}


static void GetCheesePizza(){
    Random randomm = new Random();
    int rows = randomm.Next(8, 13);                      // Generates a random number of rows between 8 and 13
        
        System.Console.WriteLine("Here is your cheese pizza slice, enjoy:");
    
    for (int i= rows; i>0; i--)                         //outer loop for the number of rows
    {
        for (int j=0; j<i; j++) 
        {
            if (j == 0 || j == i - 1)                  // Print * at the edges
            {
                System.Console.Write("* ");
            }
            else                                      // Print # for the inner cheese layer
            {
                System.Console.Write("# ");
            }
        }
        System.Console.WriteLine();                   // Move to the next line after each row
    }
    Pause();
}


static void GetPepperoniPizza(){
   Random randomm = new Random();
    int rows = randomm.Next(8, 13); // Generates a random number of rows between 8 and 13

    System.Console.WriteLine("Pepperoni Pizza slice with random pepperoni slices:");

    for (int i = rows; i > 0; i--)                // Outer loop controls the rows
    {
        for (int j = 0; j < i; j++)              // Inner loop prints crust (*), cheese (#), or pepperoni ([l])
        {
            if (i == rows || i == 1)            // Print * for the first and last rows (crust)
            {
                System.Console.Write(" * ");
            }
            else if (j == 0 || j == i - 1)     // Print * for the edges of the middle rows (crust)
            {
                System.Console.Write(" * ");
            }
            else
            {
                // Randomly place pepperoni [ ] or cheese #
                System.Console.Write(randomm.Next(0, 3) == 0 ? " [] " : " # ");
            }
        }
        System.Console.WriteLine(); // Move to the next line after each row
    }
         Pause();
    }

static void SayGoodBye(){
    System.Console.WriteLine("Thank you for visiting Jeff's Pizza, Bye Bye! Hope to see you soon");
}

static void Pause(){
    System.Console.WriteLine("Press any key to continue");
    Console.ReadKey();
}


