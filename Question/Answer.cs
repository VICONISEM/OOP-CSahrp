using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question
{
    public class Answer
    {
        #region Answer_ID

        private int answerID;
        public int AnswerID
        {
            get { return answerID; }
            set
            {
                if (value > 0)
                {
                    answerID = value;
                }
                else
                {

                    Console.WriteLine("Enter Valid ID");
                }


            }
        }

        #endregion
        #region Answer_Text
        private string? answerText;

        public string AnswerText
        {
            get { return answerText??"can't Find Answer"; }
            set
            {
                if (value is null || value.GetType() != typeof(string))
                { Console.WriteLine("Enter Valid Answer"); }

                else
                {
                    answerText = value;
                }
            }
        }
        #endregion
        public Answer(int ID, string Answer)
        {
            this.AnswerID = ID;
            this.AnswerText = Answer;
        }
        public Answer(Answer ans)
        {
            this.AnswerID = ans.AnswerID;
            this.AnswerText = ans.AnswerText;
        }
        public override string ToString()
        {
            return$"{this.AnswerText}";
        }

      

    }
}
