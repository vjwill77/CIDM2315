namespace Homework8;

class Program
{
    static void Main(string[] args)
    {
       Customer cus1=new Customer(customerName:"Alice",customerAge:33, customerCity:"Amarillo", customerCredit:198.5);
       Customer cus2=new Customer(customerName:"Bob",customerAge:23, customerCity:"Amarillo", customerCredit:226);
       Customer cus3=new Customer(customerName:"Cathy",customerAge:45, customerCity:"Amarillo", customerCredit:89.0);
       Customer cus4=new Customer(customerName:"David",customerAge:58, customerCity:"Amarillo", customerCredit:198.5);
       Customer cus5=new Customer(customerName:"Jack",customerAge:28, customerCity:"Canyon", customerCredit:561.6);
       Customer cus6=new Customer(customerName:"Tom",customerAge:36, customerCity:"Canyon", customerCredit:98.4);
       Customer cus7=new Customer(customerName:"Tony",customerAge:24, customerCity:"Canyon", customerCredit:18.5);
       Customer cus8=new Customer(customerName:"Sam",customerAge:35, customerCity:"Canyon", customerCredit:228.3);

       Customer [] customer_list = {cus1, cus2, cus3, cus4, cus5, cus6, cus7, cus8};

       //call Q1 method

       TotalCredits(customer_list);

        //call Q2 method

        AmarilloAverageAge(customer_list);

        //call Q3 method

        CanyonAge(customer_list);
    }
    //Q1. Create a method to calculate and print the total credit of all customers in the customer_list.

    public static void TotalCredits(Customer[] customer_list){
        double totalCredit = 0;
        foreach(Customer cusItem in customer_list){
            totalCredit += cusItem.customerCredit;
        }
            Console.WriteLine($"The total credits: {totalCredit}");
    }
    //Q2. Create a method to calculate and print the average age of customers living in Amarillo.
    public static void AmarilloAverageAge(Customer[] customer_list){
        double amarilloAverageAge = 0;
        double countAge = 0;
        foreach(var cusItem in customer_list){
            if(cusItem.customerCity =="Amarillo"){
                amarilloAverageAge += cusItem.customerAge;
                countAge++;
            }
        }
        if (countAge >0){
            double averageAge = amarilloAverageAge/countAge;
        Console.WriteLine($"The average age of customers in Amarillo: {averageAge}");
        }
    }

    //Q3. Create a method to print the names of customers who live in Canyon and are older than 30.
    public static void CanyonAge(Customer[] customer_list){
        string canyonCustomers = string.Empty;
        int countAge2 = 0;
        foreach(var cusItem in customer_list){
            if(cusItem.customerCity == "Canyon" && cusItem.customerAge > 30){
                if (countAge2 > 0)
                {
                    canyonCustomers += ", ";
                }
                canyonCustomers += cusItem.customerName;
                countAge2 ++;
            }
        }
        if(countAge2 > 0){
            Console.WriteLine($"Customers who live in Canyon and over 30 years old: {canyonCustomers},");
        }
    }
}
//Q0. Create a class called Customer
class Customer{
    public string customerName {get; set;} = string.Empty;
    public int customerAge {get; set;} = 0;
    public string customerCity {get; set;} = string.Empty;
    public double customerCredit {get; set;} = 0;
    

    public Customer(string customerName, int customerAge, string customerCity, double customerCredit){
        this.customerName = customerName;
        this.customerAge = customerAge;
        this.customerCity = customerCity;
        this.customerCredit = customerCredit;
    }

}
