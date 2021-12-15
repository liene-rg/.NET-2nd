using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSharp.Activity.Delegates.LoanSystem;

namespace CSharp.Activity.Delegates
{
    internal class Program
    {

        //static void Show(LoanApplicant loanApplicant)// create a method for delegate
        //{
        //    Console.WriteLine("The credit score of the applicant is " + loanApplicant.CreditScore);
        //}

        public static showApplicant Show = (LoanApplicant loanApplicant) => Console.WriteLine("The Credit score of the applicant is " + loanApplicant.CreditScore);

        static void Main(string[] args)
        {
            //            In method Main instantiate the class
            //LoanSystem and demonstate loan application processing by calling
            //the method ProcessLoanApplication() and providing the method
            //Show as the ‘callback’ method


            LoanApplicant applicant = new LoanApplicant();
            
           Console.WriteLine(applicant.CreditScore);
            Show(applicant);
           
            LoanSystem loanSystem = new LoanSystem();

            
            
           
        }
    }
}
