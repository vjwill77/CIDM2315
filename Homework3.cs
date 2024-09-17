namespace Homework3;

class Program
{
    
    static void Main(string[] args)
    
        //Code for Q1
        {
        Console.WriteLine("Input an integer: ");
        int number = Convert.ToInt16(Console.ReadLine());
        for(int num1 = 2; (num1*num1)<=number; num1++){
            if(number % num1==0){
            Console.WriteLine("N is non-prime");
            }
            else{
                Console.WriteLine("N is prime");
             }
        }
    

        //Code for Q2
        Console.WriteLine("Assign an int value to N: ");
        int n1 = Convert.ToInt16(Console.ReadLine());
        for(int n2 = 0; n2<n1; n2++){
            for(int n3 = 0; n3<n1; n3++)
            {
                Console.Write("#");
            }
            Console.WriteLine("#");
        }

        //Code for Q3
        Console.WriteLine("Assign an int value to N: ");
        int n4 = Convert.ToInt16(Console.ReadLine());
        for(int n5 = 0; n5<n4; n5++){
            for(int n6 = 0; n6<n4; n6++)
            {
                if(n5 >= n6)
                    Console.Write('*');
            }
            Console.WriteLine("");
        }

        
        //Code for Bonus question
        Console.WriteLine("Assign an int value to N: ");
        int n7 = Convert.ToInt16(Console.ReadLine());
        for(int n8=1; n8<=n7; n8++){
            for(int n9=1; n9<=n7; n9++)
            {
                if(n8>= n9)
                    Console.Write(n8);
            }
        Console.WriteLine("");
        }

    }
}
