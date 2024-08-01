using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exam;

namespace subject
{
    public class Subject
    {
        private int subID;
        public int SubID
        {
            set { subID = value; }
            get { return subID; }
        }

        private string subName;
        public string SubName
        {
            get { return subName; }
            set { subName = value; }
        }

        private Exam examOfSub;

        public Exam ExamOfSub
        {
            set { examOfSub = value; }
        }
        public Subject(int subid,string subname)
        {
            this.SubID = subid;
            this.SubName = subname;
        }
        public void CreateExam()
        {
           
            int Type;
            bool Flag;
            do
            {
                Console.Write("Chose Type of Exam (1 : Practical | 2: Final ) : ");
                Flag = int.TryParse(Console.ReadLine(), out Type);


            } while (!Flag ||!(Type >= 1 && Type <= 2));

            int NumOfQ;
            do
            {
                Console.Write("Enter Number Of Questions : ");
                Flag = int.TryParse(Console.ReadLine(),out NumOfQ);

            } while (!Flag);

            Console.Clear();

            Exam e = Type == 1 ? new Practical(NumOfQ) : new Final(NumOfQ);
            e.MakeExam();
            Console.WriteLine("Are you Want to Start Exam ? (Y|N)");
            char des;
            do
            {
                Flag = char.TryParse(Console.ReadLine(), out des);

            } while (!Flag);
            des = char.ToUpper(des);
            Console.Clear();
            if(des=='Y'&& e is Final f)
            {
                Stopwatch SW = new Stopwatch();
                SW.Start();
                f.ShowExam();
                Console.WriteLine($"the Elapsid Time{SW.Elapsed}");
            }
            else if(des=='Y'&&e is Practical p)
            {
                p.ShowExam();
            }



        }








    }
}
