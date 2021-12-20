using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSharp.Activity.Delegates.LoanSystem;

namespace CSharp.Activity.Delegates
{
    public class Program
    {

        public static showApplicant Show = (LoanApplicant loanApplicant) => Console.WriteLine("The Credit score of the applicant is " + loanApplicant.CreditScore);
      
        static void Main(string[] args)
        {
           

            LoanApplicant applicant = new LoanApplicant();
            LoanApplicant applicant1 = new LoanApplicant();
            
         
                
           LoanSystem loanSystem = new LoanSystem();


            loanSystem.ProcessLoanApplication((applicant) => Show(applicant));
            
            loanSystem.ProcessLoanApplication((applicant1) => Show(applicant1));
    }
}
    }