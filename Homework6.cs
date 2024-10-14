namespace Homework6;

class Program
{
    static void Main(string[] args)
    {
        //Answer Q1 
    Professor p1 = new Professor();
    p1.profName = "Alice";
    p1.classTeach = "Java";
    p1.SetSalary (9000);
    p1.PrintInfo();
     
    Professor p2 = new Professor();
    p2.profName = "Bob";
    p2.classTeach = "Math";
    p2.SetSalary (8000);
    p2.PrintInfo();
        
    Student s1 = new Student();
     s1.studentName = "Lisa";
     s1.classEnroll = "Java";
     s1.SetGrade (90);
     s1.PrintInfo();


    Student s2 = new Student();
     s2.studentName = "Tom";
     s2.classEnroll = "Math";
     s2.SetGrade (80);
     s2.PrintInfo();
    
    //Answer Q2
    double difference = p1.GetSalary()-p2.GetSalary();
    Console.WriteLine($"The salary difference between {p1.profName} and {p2.profName} is: {difference}");

    double totalGrade = s1.GetGrade() + s2.GetGrade();
    Console.WriteLine($"The total grade of {s1.studentName} and {s2.studentName} is: {totalGrade}");

    }
}
class Professor
{
    //Code for Professor class
    private double salary;
    public string profName;
    public string classTeach;
  
    public double GetSalary()
    {
        return salary;
    }
    public void SetSalary(double salary_amount)
    {
        salary = salary_amount;
    }
    public void PrintInfo()
    {
       Console.WriteLine($"Professor {profName} teaches {classTeach}, and the salary is: {GetSalary()}"); 
    }
}  
class Student
{
    //Code for Student class
    private double studentGrade; 
    public string studentName;
    public string classEnroll;
    
    public double GetGrade()
    {
        return studentGrade;
    }
    public void SetGrade(double newGrade)
    {
        studentGrade = newGrade;
    }  
    public void PrintInfo()
    {
        Console.WriteLine($"Student {studentName} enrolls {classEnroll}, and the grade is: {GetGrade()}");
    }
}


