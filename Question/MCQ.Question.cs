using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace question
{
    public class MCQ : Question
    {
      private Answer[] AnswerList;

      private Answer rightAnswer;

      private int NumOfChoice;
        public Answer RightAnswer
        {
            get{ return rightAnswer; }
            set { rightAnswer = new Answer(value);}

        }

        public MCQ(int NumOfChosse):base("Chose one answer Question")
        {
            this.NumOfChoice = NumOfChosse;
            AnswerList=new Answer[NumOfChoice];
        }


        public void MakeMCQ()
        {

            Console.WriteLine("Enter Body Of MCQ Question :");
            string Body = Console.ReadLine();
            this.BodyOfQ = Body;
            string AnswerText;
            for(int i=0;i<NumOfChoice;i++)
            {
                Console.Write($"Enter the Choice Number{i + 1} : ");
                
                    AnswerText = Console.ReadLine();
                    AnswerList[i] = new Answer(i + 1, AnswerText);

            }
        }
        public void AddRightChoice()
        {
            Console.Write("Enter ID of right Choice");
            int ID;
            bool flag;

            do
            {
                flag = int.TryParse(Console.ReadLine(), out ID);
                if(!flag)
                {
                    Console.WriteLine("Enter Valid ID");
                }

                else if (AnswerList[ID--] != null)
                {
                    RightAnswer =new Answer(AnswerList[ID--]);
                }
                else
                {
                    Console.WriteLine("this Answer doesnt exsite!");
                }

            } while (!flag || (ID <= 0)||(ID>NumOfChoice));

        }

      













    }
}
