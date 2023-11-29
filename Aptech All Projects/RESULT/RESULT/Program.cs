using System;

namespace RESULT
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome To The Benchmark Protal\n");
            Console.WriteLine("Enter the Followng to get your result\n");

            Console.WriteLine("What Is your Name");
            string name = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("What Is Your Class");
            int studentClass = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            //Subject Marks

            Console.WriteLine("Computer Marks");
            int computer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Maths Marks");
            int maths = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Urdu Marks");
            int urdu = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("English Marks");
            int english = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            int totalMarks = computer + maths + urdu + english;
            Console.WriteLine("Your Total Is :" + totalMarks);
            Console.WriteLine("\n");

            double percentage = (totalMarks / 400.0) * 100;
            Console.WriteLine("Percentage: " + percentage + "%");
            Console.WriteLine("\n");

            Console.WriteLine("Final Result");
            Console.WriteLine("\n");
            string massage = $"YOUR NAME IS {name} YOU ARE THE STUDENT OF {studentClass} AND";

            //Condition On Grading

            if (percentage >= 80)
            {
                Console.WriteLine(massage);
                Console.WriteLine("Your Persentage is : " + percentage + " According To The Persentage Your Grade Is A*");
                Console.WriteLine("\n");

            }
            else if (percentage >= 70)
            {
                Console.WriteLine(massage);
                Console.WriteLine("Your Persentage is : " + percentage + " According To The Persentage Your Grade Is A");
                Console.WriteLine("\n");

            }
            else if (percentage >= 60)
            {
                Console.WriteLine(massage);
                Console.WriteLine("Your Persentage is : " + percentage + " According To The Persentage Your Grade Is B");
                Console.WriteLine("\n");

            }
            else if (percentage >= 50)
            {
                Console.WriteLine(massage);
                Console.WriteLine("Your Persentage is : " + percentage + " According To The Persentage Your Grade Is C");
                Console.WriteLine("\n");

            }
            else if (percentage >= 40)
            {
                Console.WriteLine(massage);
                Console.WriteLine("Your Persentage is : " + percentage + " According To The Persentage Your Grade Is D");
                Console.WriteLine("\n");

            }
            else if (percentage >= 30)
            {
                Console.WriteLine(massage);
                Console.WriteLine("Your Persentage is : " + percentage + " According To The Persentage Your Grade Is E");
                Console.WriteLine("\n");

            }
            else
            {
                Console.WriteLine(massage);
                Console.WriteLine("Your Persentage is : " + percentage + " According To The Persentage Your Are Faild The Exam");
                Console.WriteLine("\n");

            }
        }
    }
}
