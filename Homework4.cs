namespace Homework4;

class Program
{
    static void Main(string[] args)
    {
        //Call Q1_method()
        string input_num1 = Console.ReadLine();
        int a=Convert.ToInt16(input_num1);
        string input_num2 = Console.ReadLine();
        int b=Convert.ToInt16(input_num2);
        LargestNum(a, b);

        //Call Q2_method()
        string input_num3 = Console.ReadLine();
        int N=Convert.ToInt16(input_num3);
        string input_shape = Console.ReadLine();
        Question2(N, input_shape);
        
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
    static void Question2(int N, string input_shape){
       //nested-for loop to print left triangle
       if(input_shape=="left")
       {
        for(int i = 0; i<N; i++)
        {
            for(int j = 0; j<=i; j++)
            {
            Console.Write('*');
            }
            Console.WriteLine("");
            }
       }
        //code to print right-side traingle
        else if(input_shape =="right")
        {
        for(int i = 0; i<N; i++)
        {
            for(int j = 0; j < N - i - 1; j++)
            {
            Console.Write(' ');    
            }
            for(int j= 0; j<=i; j++)
            {
            Console.Write('*');
            }
            Console.WriteLine("");
            }
        
        }
    }    
    
}
