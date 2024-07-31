using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question
{
    public class Question
    {
        #region Header_of_the_question

        private string? headerOfQ;
        public string HeaderOfQ
        {
            get { return headerOfQ ?? "Question can not find"; }

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
        private string? bodyOfQ;


        public string BodyOfQ
        {
            get { return bodyOfQ ?? "Question can not find!"; }

            set
            {
                if (value is null)
                {
                    Console.WriteLine("please enter valid body!");
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
        public Question(string Header)
        {
           this.HeaderOfQ = Header;
        }





        #endregion

    }
}
