namespace Homework9;

class Program
{
    static void Main(string[] args)
    {
    //Q2 Create 4 students
        Student alice = new Student(111,"Alice");
        Student bob = new Student(222,"Bob");
        Student cathy = new Student(333,"Cathy");
        Student david = new Student(444,"David");
      
    //Q3 Create a Dictionary named gradebook to hold the student's and the GPA
    Dictionary<string, double> gradebook = new Dictionary<string, double>();

    gradebook.Add("Alice", 4.0);
    gradebook.Add("Bob", 3.6);
    gradebook.Add("Cathy", 2.5);
    gradebook.Add("David", 1.8);

    double gpaAverage = 0;
    double countGpa = 0;

    //Q4 Check if "Tom" has a record in gradebook. If "Tom" is NOT in the gradebook, insert Tom into gradebook with GPA of 3.3
    if(!gradebook.ContainsKey("Tom"))
    {
        gradebook.Add("Tom", 3.3);
    }
  
    //Q5 Calculate the average GPA of all students, and print out the average GPA.
    foreach(var student in gradebook){
        gpaAverage += student.Value;
        countGpa++;
        }
        if (countGpa > 0){
            double averageGpa = gpaAverage/countGpa;
        Console.WriteLine($"The average GPA is: {averageGpa}");
        
    //Q6 Print out information about students whose GPA is greater than the average GPA.
    foreach(var student in gradebook)
        {
        if(student.Value > averageGpa)
            {
        Student matchedStudent = Student.studentList.Find(s => s.StudentName == student.Key);
            if(matchedStudent != null)
                {
                matchedStudent.PrintInfo();
                }
             }        
        }        
    } 
    }
}
//Q1 Create a Student Class
class Student{
    //public static studentList
    public static List<Student> studentList = new List<Student>();

    //private studentID: int
    private int studentID{ get; set; }
    //private studentName: string
    private string studentName{ get; set; }

    public string StudentName => studentName;

    //public PrintInfo(): void, print out students whos GPA is greater than the average GPA.
    public void PrintInfo(){
        Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
    }
    //public Student() constructor: after creating a new student object, add this object to the studentList
    public Student(int inputID, string inputName){
        studentID = inputID;
        studentName = inputName;
        studentList.Add(this);
    }
}
/*Your code looks great overall! However, there are a few issues that need to be fixed. I’ll point them out and suggest corrections:

Dictionary Check for "Tom": The way you're checking if "Tom" exists in the dictionary is incorrect. Instead of using Contains(), use ContainsKey(), and you don't need a loop for this check.

Adding "Tom" to the Dictionary: You need to add "Tom" directly if he is not found.

Calculating Average GPA: Make sure to calculate the average GPA after you may have added "Tom".

Printing Students with GPA Greater than Average: You need to filter the students based on the GPA in the dictionary instead of iterating through Student.studentList.
Key Changes Made:
Used ContainsKey() to check for "Tom".
Added "Tom" directly into the dictionary if not present.
Adjusted the logic for printing students based on GPA to use the dictionary instead of the static student list.*/
