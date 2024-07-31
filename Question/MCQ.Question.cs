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
            
        }

        public MCQ(int NumOfChosse):base("Chose one answer Question")
        {
            this.NumOfChoice = NumOfChosse;
            AnswerList=new Answer[NumOfChoice];
        }


        public override void MakeQ()
        {

            Console.Write("Enter Body Of MCQ Question :");
            
            this.BodyOfQ = Console.ReadLine()??"";
            string AnswerText;
            for(int i=0;i<NumOfChoice;i++)
            {
                Console.Write($"Enter the Choice Number{i + 1} : ");
                
                    AnswerText = Console.ReadLine();
                    AnswerList[i] = new Answer(i + 1, AnswerText);

            }
            AddRightChoice();
            Console.Write("Enter Mark Of MCQ Question :");
            int Mark;
            bool flag;
            do
            {
                Console.Write("Enter Mark Of MCQ Question :");
                flag = int.TryParse(Console.ReadLine(), out Mark);

            } while (!flag||Mark<=0);
            this.MarkOfQ = Mark;
        }
        public void AddRightChoice()
        {
            
            int ID;
            bool flag;

            do
            {
                Console.Write("Enter ID of right Choice");
                flag = int.TryParse(Console.ReadLine(), out ID);
               

                if (AnswerList[--ID] != null)
                {
                    rightAnswer =new Answer(AnswerList[--ID]);
                }
                else
                {
                    Console.WriteLine("this Answer doesnt exsite!");
                }

            } while (!flag);

        }
        public override string ToString()
        {
            string Q;
            Q = this.BodyOfQ;
            Q += $"     Mark ({this.MarkOfQ}) \n";
            foreach(var ans in AnswerList)
            {
                Q += ans.AnswerID.ToString()+" . "+ans.AnswerText + "    ";

            }
            return Q;

        }


    }
}
