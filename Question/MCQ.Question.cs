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

      private int NumOfChoice;

        public MCQ(int NumOfChosse):base("Choose the correct answer")
        {
            this.NumOfChoice = NumOfChosse;
            AnswerList=new Answer[NumOfChoice];
        }



        #region MakeQuestion

        public override void MakeQ()
        {

            do
            {
                Console.Write("Enter Body Of MCQ Question :");
                this.BodyOfQ = Console.ReadLine();
            } while (string.IsNullOrEmpty(this.BodyOfQ));
           
            string AnswerText;
            for(int i=0;i<NumOfChoice;i++)
            {
                do
                {
                    Console.Write($"Enter the Choice Number{i + 1} : ");
                    AnswerText = Console.ReadLine();

                } while (string.IsNullOrEmpty(AnswerText));
                AnswerList[i] = new Answer(i + 1, AnswerText);
            }
            AddRightChoice();
            int Mark;
            bool flag;
            do
            {
                Console.Write("Enter Mark Of MCQ Question :");
                flag = int.TryParse(Console.ReadLine(), out Mark);

            } while (!flag||!(Mark>0));
            this.MarkOfQ = Mark;
            Console.Clear();
        }
        #endregion

        #region AddRightChoice
        public void AddRightChoice()
        {
            
            int ID;
            bool flag;

            do
            {
                Console.Write("Enter ID of right Choice : ");
                flag = int.TryParse(Console.ReadLine(), out ID);
               
            } while (!flag||!(ID<=this.NumOfChoice));

            if (AnswerList[--ID] != null)
            {
                RightAnswer = new Answer(AnswerList[ID]);
            }
            else
            {
                Console.WriteLine("this Answer doesnt exsite!");
            }

        }

        #endregion
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
