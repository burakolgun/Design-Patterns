using ChainOfRespobility.Data;
using ChainOfResponsibility.Business;
using System;
using System.Globalization;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define successors
            var firstNameValidator = new FirstNameValidator();
            var lastNameValidator = new LastNameValidator();
            var ageValidator = new AgeValidator();

            //Init successors in sequence
            firstNameValidator.SetSuccessor(lastNameValidator);
            lastNameValidator.SetSuccessor(ageValidator);

            var account = new Account()
            {
                Age = 20,
                BankCreditRequestEnum = ChainOfRespobility.Data.Enums.BankCreditRequestEnum.Financial,
                FirstName = "Linus",
                LastName = "Torvalds"
            };

            try
            {
                firstNameValidator.ValidateBankCreditRequest(account);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{account.FirstName} {account.LastName} credit request has been denied\n" +
                    $"Reason : {ex.Message}\n\n");
            }

            var account2 = new Account()
            {
                Age = 30,
                BankCreditRequestEnum = ChainOfRespobility.Data.Enums.BankCreditRequestEnum.IndividualLoan,
                FirstName = "Steve",
                LastName = "Jobs"
            };

            firstNameValidator.ValidateBankCreditRequest(account2);

            Console.WriteLine("-------------");
            Console.WriteLine("Approved Account Info\n");
            Console.WriteLine($"Id : {account2.Id}\n");
            Console.WriteLine($"First Name : {account2.FirstName}\n");
            Console.WriteLine($"Last Name : {account2.LastName}\n");
            Console.WriteLine($"Age : {account2.Age}\n");
            Console.WriteLine($"Approved Date : {account2.CreatedAt.ToString("MM/dd/yyyy HH:mm:ss.fff", CultureInfo.InvariantCulture)}\n");
            Console.WriteLine("-------------");
        }
    }
}
