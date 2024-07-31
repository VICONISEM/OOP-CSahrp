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

        public override void MakeQ()
        {
            throw new NotImplementedException();
        }
    }
}
