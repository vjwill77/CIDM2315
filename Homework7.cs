namespace Homework7;

class Program
{
    static void Main(string[] args)
    {
        //Answer Q1 and Q2
        Customer Alice = new Customer(cus_id: 110, cus_name: "Alice", cus_age: 28);
        Alice.PrintCusInfo();
        Customer Bob = new Customer(cus_id: 111, cus_name: "Bob", cus_age: 30);
        Bob.PrintCusInfo();
        //change and print updated ID
        Alice.ChangeID(220);
        Alice.PrintCusInfo();

        Bob.ChangeID(221);
        Bob.PrintCusInfo();

        Alice.CompareAge(Bob);
        
    }
}
class Customer
{
    //Code for Customer class
    private int cus_id { get; set; }
    public string cus_name { get; set; }
    public int cus_age { get; set; }
  
    public Customer(int cus_id, string cus_name, int cus_age)//constructor used to assign id, name and age to the customer when an object is created.
    {
        this.cus_id = cus_id;
        this.cus_name = cus_name;
        this.cus_age = cus_age;
    }
    public void ChangeID(int new_id)//method used to change customer id
    {
        cus_id = new_id;
    }
    public void PrintCusInfo()   //method used to print customer information(id, name, age)
    {
      Console.WriteLine($"Customer: {cus_id}, name: {cus_name}, age:{cus_age}");
    }
       
    public void CompareAge(Customer objCustomer)//method used to compare the current object's age with the objCustomer's age. Then print out the cus_name of the older customer.
    {
        if(this.cus_age > objCustomer.cus_age)
        {
            Console.WriteLine($"{this.cus_name} is older");
        }
        else
        {
            Console.WriteLine($"{objCustomer.cus_name} is older");
        }
    }
}

