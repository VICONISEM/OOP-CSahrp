using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace question
{
    public class T_F : Question
    {
       
        private Answer[] AnswerList;

        private Answer rightAnswer;
        public T_F() : base("True Or False Question")
        {
            AnswerList = new Answer[2] { 
            new Answer(1,"True"), new Answer(2,"False")  
            };
        }


        public Answer RightAnswer
        {
            get { return rightAnswer; }
        }

        public override void MakeQ()
        {
            Console.Write("Enter Body Of Question :");
            this.BodyOfQ = Console.ReadLine();
           
            bool flag;
            int id;
            int Mark;
            do
            {
                Console.Write("Enter ID Of Right Answer(1:True|2:False): ");
                flag = int.TryParse(Console.ReadLine(), out id);

            } while (!flag||!(id>=1&&id<=2));
            if(id==1)
            {
                rightAnswer = new Answer(1, "True");
            }
            else
            {
                rightAnswer = new Answer(2, "False");
            }


            do
            {
                Console.Write("Enter Mark Of Question : ");
                flag = int.TryParse(Console.ReadLine(), out Mark);
            } while (!flag||(Mark<=0));

            this.MarkOfQ = Mark;

        }


        public override string ToString()
        {
            return$"{this.BodyOfQ} (1:True|2:False)     Mark ({this.MarkOfQ})" ;
        }


    }
}
