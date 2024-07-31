using question;


namespace OOP_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Question question = new MCQ(4);
            question.MakeQ();
            Console.WriteLine(question);
           

        }
    }
}
