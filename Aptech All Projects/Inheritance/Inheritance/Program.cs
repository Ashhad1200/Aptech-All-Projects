using System.Runtime.InteropServices.JavaScript;

namespace Inheritance
{   //parent class //  
    class Employee
    {
        public int empId;
        public string empName;
        public string empEmail;
        public Int64 contact;
        public string design;
        //set values // setter method
        public void SetEmployeeData(int id, string name, string email, Int64 contact, string design)
        {
            this.empId = id;
            this.empName = name;
            this.empEmail = email;
            this.contact = contact;
            this.design = design;
        }
        public void DisplayRecord()
        {
            Console.WriteLine("Employee id:" + empId);
            Console.WriteLine("Employee name:" + empName);
            Console.WriteLine("Employee Designation:" + design);
            Console.WriteLine("Employee Email:" + empEmail);
            Console.WriteLine("Employee Contact:" + contact);
        }
    }
    // child class
    class Permanent_Employee : Employee
    {
        int per_credit_hrs;
        int per_salary;
        //set values // setter 
        public void Set_Per_Data(int hrs, int sal)
        {
            this.per_credit_hrs = hrs;
            this.per_salary = sal;
        }
        //print record // getter
        public void Get_Per_Salary()
        {
            Console.WriteLine("Permanent Employee Credit Hours" + per_credit_hrs);
            Console.WriteLine("Emloyee Salary:" + per_salary);
        }
    }
    // child class
    class Part_Time_Employee : Employee
    {
        int part_credit_hrs;
        int part_salary;
        //set values // setter 
        public void Set_Part_Timer_Data(int hrs, int sal)
        {
            this.part_credit_hrs = hrs;
            this.part_salary = sal;
        }
        //print record // getter
        public void Get_Part_Timer_Salary()
        {
            Console.WriteLine("Permanent Employee Credit Hours" + part_credit_hrs);
            Console.WriteLine("Emloyee Salary:" + part_salary);
        }
    }
    // child class
    class Visitor_Employee : Employee
    {
        int vis_credit_hrs;
        int vis_salary;
        //set values // setter 
        public void Set_Visitor_Data(int hrs, int sal)
        {
            this.vis_credit_hrs = hrs;
            this.vis_salary = sal;
        }
        //print record // getter
        public void Get_Visitor_Salary()
        {
            Console.WriteLine("Permanent Employee Credit Hours" + vis_credit_hrs);
            Console.WriteLine("Emloyee Salary:" + vis_salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Permanent_Employee emp1 = new Permanent_Employee();
            emp1.empId = 1;
            emp1.empName = "Ahmed";
            emp1.design = "Web Designing";
            emp1.contact = 923121231234;
            emp1.empEmail = "ahmed@gmail.com";
            emp1.Set_Per_Data(8, 45000);
            emp1.DisplayRecord();
            emp1.Get_Per_Salary();
            //Child class object 
            Part_Time_Employee emp2 = new Part_Time_Employee();
            emp2.SetEmployeeData(2, "Muhammad", "mh@gmail.com", 03128877665, "Web Designer");
            emp2.DisplayRecord();
            emp2.Set_Part_Timer_Data(4, 20000);
            emp2.Get_Part_Timer_Salary();

        }
    }
}