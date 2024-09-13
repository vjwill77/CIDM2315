namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
        //Code for Q1
        Console.WriteLine("Please input a letter grade: ");
        string answer = Console.ReadLine();
        if(answer =="A" || answer =="a")
        {
            Console.WriteLine("GPA point: 4");
        }
        else if(answer =="B" || answer =="b")
        {
            Console.WriteLine("GPA point: 3");
        }
        else if(answer =="C"|| answer =="c")
        {
            Console.WriteLine("GPA point: 2");
        }
        else if(answer =="D"|| answer =="d")
        {
            Console.WriteLine("GPA point: 1");
        }
        else if(answer =="F"|| answer =="f")
        {
            Console.WriteLine("GPA point: 0");
        }
        else
        {
            Console.WriteLine("Wrong Letter Grade!");
        }
        
        
        //Code for Q2
        Console.WriteLine("Please input the first num: ");
        string input1 =Console.ReadLine();
        Console.WriteLine("Please input the second num: ");
        string input2 =Console.ReadLine();
        Console.WriteLine("Please input the third num: ");
        string input3 =Console.ReadLine();
        int n1 = Convert.ToInt16(input1);
        int n2 = Convert.ToInt16(input2);
        int n3 = Convert.ToInt16(input3);
        
        if(n1<n2){
            if(n1<n3){
                Console.WriteLine($"The smallest value is: {n1}");
            }
            else{
                Console.WriteLine($"The smallest value is: {n3}");
            }
        }
        else{
            if(n2<n3){
                Console.WriteLine($"The smallest value is: {n2}");
            }
            else{
                Console.WriteLine($"The smallest value is: {n3}");
            }
        }
        

        //Code for Bonus question
       

    


    }
}

