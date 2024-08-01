using question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    public class Final : Exam
    {
        public Final(int NumOfQ) : base(NumOfQ)
        {
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
            this.TimeOfExam = Time;
            Console.Clear();

            for(int i=0;i<this.NumberOfQuestion;i++)
            {
                int Type=0;

                do
                {
                    Console.Write("Enter Type Of Question (1:MCQ|2:True or False) :");
                    Flag = int.TryParse(Console.ReadLine(), out Type);

                } while (!Flag||!(Type>=1&&Type<=2));
                Console.Clear();

                if(Type==1)
                {
                    int NumOfChoices;
                    do
                    {
                        Console.Write($"Enter Number of choices for question {i + 1} :");
                        Flag = int.TryParse(Console.ReadLine(),out NumOfChoices);
                    } while (!Flag||!(NumOfChoices>0));

                    QS[i] = new MCQ(NumOfChoices);
                    QS[i].MakeQ();
                    

                }
                else
                {
                    QS[i] = new T_F();
                    QS[i].MakeQ();
                }
                this.MarkOfExam += QS[i].MarkOfQ;
            }
            


        }
        public override void ShowExam()
        {
            int GradeOfUser = 0;

            for (int i = 0; i < this.NumberOfQuestion; i++)
            {
                Console.WriteLine($"{QS[i].HeaderOfQ}");
                Console.WriteLine($"{i + 1}.{QS[i]}");
                Console.Write("Enter ID of Write Answer :");
                int ID;
                bool Flag;
                do
                {
                    Flag = int.TryParse(Console.ReadLine(), out ID);

                } while (!Flag || !(ID > 0));
                if (QS[i].RightAnswer.AnswerID == ID)
                {
                    GradeOfUser += QS[i].MarkOfQ;
                }
                Console.WriteLine("-----------------------------------------------");
            }
            Console.WriteLine("*****************************************************");


            for (int i = 0; i < this.NumberOfQuestion; i++)
            {
                Console.WriteLine($"{i + 1} .{QS[i].BodyOfQ} ===>{QS[i].RightAnswer}");
            }

            Console.WriteLine($"You Get {GradeOfUser} of {this.MarkOfExam}");






        }
    }
}
