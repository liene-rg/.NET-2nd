using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Activity.Delegates
{
    public class LoanSystem
    {

        public delegate void showApplicant(LoanApplicant loanApplicant); 

        public static Random random = new Random();


        public void ProcessLoanApplication(Action<LoanApplicant> showApplicant)
        {

            LoanApplicant loanApplicant = new LoanApplicant();

            loanApplicant.CreditScore = random.Next(1, 101);

            showApplicant(loanApplicant);

        }

    }
}
      

      

    

