using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using question;

namespace exam
{
    public abstract class Exam
    {
        private int timeOfExam;

        public int TimeOfExam
        {
            get { return timeOfExam; }
            set { timeOfExam = value; }
        }

        private int numberOfQuestion;
        
        public int NumberOfQuestion
        {
            get { return numberOfQuestion; }
            set { numberOfQuestion = value;}
        }
        private int  markOfExam;
        public int MarkOfExam
        {
            set { markOfExam = value;}
            get { return markOfExam; }
        }



        private Question[] qs;


        public Exam(int NumOfQ)
        {
            this.NumberOfQuestion = NumOfQ;
            qs = new Question[this.NumberOfQuestion];
            this.MarkOfExam = 0;
        }
        public Question[] QS
        {
            get { return qs; }
        }
        public Question this[int i]
        {
            get { return qs[i];}
            set { qs[i] = value; }

        }




        public abstract void MakeExam();
        public abstract void ShowExam();



    }
}
