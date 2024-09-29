namespace Homework5;

class Program
{
    static void Main(string[] args)
    {
        //Call Q1 Method
        string input_num1 = Console.ReadLine();
        int a=Convert.ToInt16(input_num1);

        string input_num2 = Console.ReadLine();
        int b=Convert.ToInt16(input_num2);

        LargestNum(a, b);
        
        //Call Q2 Method
        string input_num3 = Console.ReadLine();
        int c=Convert.ToInt16(input_num3);

        string input_num4 = Console.ReadLine();
        int d=Convert.ToInt16(input_num4);

        LargestNum2(a, b, c, d);
        
        
        //Call Q3 Method
        Console.WriteLine("Enter Your Username: ");
        string username = Console.ReadLine();

        Console.WriteLine("Enter Your Password: ");
        string password = Console.ReadLine();

        Console.WriteLine("Enter Your Password Again: ");
        string password2 = Console.ReadLine();

        Console.WriteLine("Enter Your Birthyear: ");
        string input_year = Console.ReadLine();
        int year=Convert.ToInt16(input_year);

        bool isAge = checkAge(year);
        bool isPassword = checkPassword(password, password2); 

        createAccount(isAge, isPassword);

    }

    //Q1_method
    static void LargestNum(int a, int b){
        Console.WriteLine($"a={a}; b={b}");
        if(a>b){
        Console.WriteLine($"The largest number is:{a}");
        }
        else{
        Console.WriteLine($"The largest number is:{b}");
        }
            
     }
              
    
    //Q2_method
   static void LargestNum2(int a, int b, int c, int d){
        Console.WriteLine($"a={a}; b={b}; c={c}; d={d};");
        int largest = Math.Max(Math.Max(a, b), Math.Max(c,d));
        Console.WriteLine($"The largest number is: {largest}");
   }     
    

    //Q3_method
    static bool checkPassword(string pass1, string pass2){
        return pass1 == pass2;
        

    }
    static bool checkAge(int birth_year){
        int age = 2024 - birth_year;
        return age>= 18;
        
    }
    static void createAccount(bool isAge, bool isPassword){
        if(isAge && isPassword){
            Console.WriteLine("Account is created successfully");
        }
        else if(!isPassword){
            Console.WriteLine("Wrong password");
        }
        else{
            Console.WriteLine("Could not create an account");
        }
        /* Had to review in ChatGPT - This was the feedback I received from it.
        
        Your C# code has a few issues that need fixing to ensure it compiles and runs correctly. Here's a revised version with corrections and improvements:

csharp

using System;

class Program
{
    static void Main(string[] args)
    {
        // Call Q1 Method
        Console.WriteLine("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());
        
        LargestNum(a, b);
        
        // Call Q2 Method
        Console.WriteLine("Enter third number: ");
        int c = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter fourth number: ");
        int d = Convert.ToInt32(Console.ReadLine());
        
        LargestNum(a, b, c, d);
        
        // Call Q3 Method
        Console.WriteLine("Enter Your Username: ");
        string username = Console.ReadLine();
        
        Console.WriteLine("Enter Your Password: ");
        string password = Console.ReadLine();
        
        Console.WriteLine("Enter Your Password Again: ");
        string password2 = Console.ReadLine();
        
        Console.WriteLine("Enter Your Birthyear: ");
        int year = Convert.ToInt32(Console.ReadLine());
        
        bool isAge = checkAge(year);
        bool isPassword = checkPassword(password, password2);
        
        Summary(isAge, isPassword);
    }

    // Q1 method
    static void LargestNum(int a, int b)
    {
        Console.WriteLine($"a={a}; b={b}");
        if (a > b)
        {
            Console.WriteLine($"The largest number is: {a}");
        }
        else
        {
            Console.WriteLine($"The largest number is: {b}");
        }
    }

    // Q2 method
    static void LargestNum(int a, int b, int c, int d)
    {
        Console.WriteLine($"a={a}; b={b}; c={c}; d={d};");
        int largest = Math.Max(Math.Max(a, b), Math.Max(c, d));
        Console.WriteLine($"The largest number is: {largest}");
    }

    // Q3 method
    static bool checkPassword(string pass1, string pass2)
    {
        return pass1 == pass2;
    }

    static bool checkAge(int birth_year)
    {
        int age = 2024 - birth_year;
        return age >= 18;
    }

    static void Summary(bool isAge, bool isPassword)
    {
        if (isAge && isPassword)
        {
            Console.WriteLine("Account is created successfully");
        }
        else if (!isPassword)
        {
            Console.WriteLine("Wrong password");
        }
        else
        {
            Console.WriteLine("Could not create an account");
        }
    }
}

Key Changes Made:

    Input Handling: Added prompts for clarity when asking for input.
    Type Conversion: Changed Convert.ToInt16 to Convert.ToInt32 to handle larger numbers.
    Logical Errors: Fixed the logic in the Summary method to use && for conditions and corrected variable references.
    Largest Number Logic: Updated the second LargestNum method to find the largest among all four numbers using Math.Max.
    Method Signatures: Specified types for the parameters in the Summary method.

Notes:

    Always validate user input in a real application to prevent errors and exceptions.
    Consider using more informative prompts and messages for user interaction.*/
    }
}
