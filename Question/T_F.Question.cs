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
       
        public T_F() : base("True Or False Question")
        {
            AnswerList = new Answer[2] { 
            new Answer(1,"True"), new Answer(2,"False")  
            };
        }



        #region MakeQuestion
        public override void MakeQ()
        {
            do
            {
                Console.Write("Enter Body Of Question :");
                this.BodyOfQ = Console.ReadLine();

            } while (string.IsNullOrEmpty(this.BodyOfQ));
           
           
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
                RightAnswer = new Answer(1, "True");
            }
            else
            {
                RightAnswer = new Answer(2, "False");
            }


            do
            {
                Console.Write("Enter Mark Of Question : ");
                flag = int.TryParse(Console.ReadLine(), out Mark);
            } while (!flag||(Mark<=0));

            this.MarkOfQ = Mark;

        }
        #endregion

        public override string ToString()
        {
            return$"{this.BodyOfQ} (1:True|2:False)     Mark ({this.MarkOfQ})" ;
        }


    }
}
