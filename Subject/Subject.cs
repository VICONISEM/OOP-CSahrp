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
        #region subID
        private int subID;
        public int SubID
        {
            set { subID = value; }
            get { return subID; }
        }
        #endregion


        #region subName
        private string subName;
        public string SubName
        {
            get { return subName; }
            set { subName = value; }
        }
        #endregion


        #region examOfSub
        private Exam examOfSub;

        public Exam ExamOfSub
        {
            set { examOfSub = value; }
        }

        #endregion
        public Subject(int subid,string subname)
        {
            this.SubID = subid;
            this.SubName = subname;
        }

        #region CreateExam
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

            } while (!Flag||!(NumOfQ>0));

            Console.Clear();

            Exam e = ( Type == 1) ? new Practical(NumOfQ) : new Final(NumOfQ);
            e.MakeExam();
            
            char des;
            do
            {
                Console.WriteLine("Are you Want to Start Exam ? (Y|N)");
                Flag = char.TryParse(Console.ReadLine(), out des);
                des = char.ToUpper(des);

            } while (!Flag||!(des=='Y'||des=='N'));
            
            Console.Clear();
            if(des=='Y'&& e is Final f)
            {
                Stopwatch SW = new Stopwatch();
                SW.Start();
                f.ShowExam();
                Console.WriteLine($"the Elapsed Time{SW.Elapsed}");
            }
            else if(des=='Y'&&e is Practical p)
            {
                p.ShowExam();
            }



        }

        #endregion






    }
}
