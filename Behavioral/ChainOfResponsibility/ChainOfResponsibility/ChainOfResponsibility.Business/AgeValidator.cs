using ChainOfRespobility.Data;
using ChainOfRespobility.Data.Constants;
using ChainOfResponsibility.Business.Exceptions;
using System.Linq;

namespace ChainOfResponsibility.Business
{
    public class AgeValidator : BankCreditValidator
    {
        public override void ValidateBankCreditRequest(Account account)
        {
            var isBankCreditRequestValidForAge = BankCreditValidatorConstants.ageRulesDictionary
                .Where(q => q.Key.Equals(account.BankCreditRequestEnum))
                .FirstOrDefault().Value
                .Where(q => q.Key <= account.Age && q.Value >= account.Age)
                .Any();

            var isAgeValid = account.Age > default(int) && isBankCreditRequestValidForAge;

            if(!isAgeValid)
            {
                throw new InvalidAgeException($"Age {account.Age} is invalid for {account.BankCreditRequestEnum.ToString()} credit request");
            }
        }
    }
}
