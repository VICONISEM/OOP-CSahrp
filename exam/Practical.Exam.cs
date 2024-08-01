using question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace exam
{
    public class Practical : Exam
    {

        public Practical(int NumOfQ) : base(NumOfQ)
        {
            this.NumberOfQuestion = NumOfQ;
        }

        
        public override void MakeExam()
        {
            bool Flag;
            int Time;
            do
            {
                Console.Write("Enter Time Of Exam :");
                Flag = int.TryParse(Console.ReadLine(), out Time);    

            } while (!Flag);
            Console.Clear();
            this.TimeOfExam = Time;

            for (int i = 0; i < this.NumberOfQuestion; i++)
            {

                int NumOfChoice;
                do
                {
                    Console.Write($"Enter Number of choices for question {i + 1}: ");
                    Flag = int.TryParse(Console.ReadLine(), out NumOfChoice);

                } while (!Flag);

                QS[i] = new MCQ(NumOfChoice);
                QS[i].MakeQ();
            
            }





        }

        public override void ShowExam()
        {
            int GradeOfUser = 0;
            
            for (int i = 0; i < this.NumberOfQuestion; i++)
            {
                Console.WriteLine($"{QS[i].HeaderOfQ}");
                Console.WriteLine($"{i+1}.{QS[i]}");
                Console.Write("Enter ID of Write Answer : ");
                int ID;
                bool Flag;
                do
                {
                    Flag = int.TryParse(Console.ReadLine(),out ID);

                } while (!Flag||!(ID>0));
                if (QS[i].RightAnswer.AnswerID==ID)
                {
                    GradeOfUser += QS[i].MarkOfQ;
                }
                Console.WriteLine("-----------------------------------------------");
            }

            Console.WriteLine("*****************************************************");

            for (int i = 0; i < this.NumberOfQuestion; i++)
            {
                Console.WriteLine($"{i+1} .{QS[i].BodyOfQ} ===>{QS[i].RightAnswer}");
            }






        }
    }
}
