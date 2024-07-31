using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using question;

namespace OOP_Exam.Exam
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


        public abstract void ShowExam();
        public abstract void MakeExam();



    }
}
