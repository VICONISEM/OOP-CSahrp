using question;
using exam;
using subject;

namespace OOP_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int Id;
            string Name;
            bool flag;
            Console.Write("Enter Name Of Subject : ");
            Name = Console.ReadLine();



            do
            {
                Console.Write("Enter ID Of Subject : ");
                flag=int.TryParse(Console.ReadLine(), out Id );
            } while (!flag);


            Console.Clear();
            Subject sub = new Subject(Id,Name);
            sub.CreateExam();
           
           

        }
    }
}
