using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question
{
    public abstract class Question
    {
        #region Header_of_the_question

        private string headerOfQ;
        public string HeaderOfQ
        {
            get { return headerOfQ ?? " Header of Question can not find"; }

            set
            {
                if (value is null)
                {
                    Console.WriteLine("please enter valid Header");
                }
                else
                {
                    headerOfQ = value;
                }
            }

        }



        #endregion

        #region Body_of_the_question
        private string bodyOfQ;


        public string BodyOfQ
        {
            get { return bodyOfQ ?? "Body OF Question can not find!"; }

            set
            {
                if (value is null||value.GetType() != typeof(string))
                {
                    Console.WriteLine("please enter valid body!");
                }
                else
                {
                    bodyOfQ = value;

                }
            }




        }


        #endregion

        #region Mark
        private int markOfQ;
        public int MarkOfQ
        {
            get { return markOfQ; }
            set
            {
                markOfQ = value > 0 ? value : 2;
            }

        }
        #endregion

        #region NumOfChoice
        private int numOfChoice;


        public int NumOfChoice
        {
            get { return numOfChoice; }
            set { numOfChoice = value; }
        }
        #endregion

        #region right_answer

        private Answer rightAnswer;
        public Answer RightAnswer
        {
            get { return rightAnswer; }
            set { rightAnswer = value; }
        }
        #endregion

        #region AnswerList
        private Answer[] answerList;

        public Answer[] AnswerList
        {
            get { return answerList; }
            set { answerList = value; }
        }
        #endregion





        public Question(string Header, int NumOfCh)
        {
           this.HeaderOfQ = Header;
           this.NumOfChoice= NumOfCh;
        }

        public abstract void MakeQ();

    }
}
