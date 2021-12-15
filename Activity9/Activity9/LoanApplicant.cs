using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Activity.Delegates
{
    public class LoanApplicant
    {

        public double CreditScore { get; set; }


        public LoanApplicant()
        {
            Random random = new Random();
            this.CreditScore = random.Next(1, 101);
        }

       

        

            
     
       



        


    }
}
