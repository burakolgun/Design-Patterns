using ChainOfRespobility.Data;
using ChainOfRespobility.Data.Constants;
using ChainOfResponsibility.Business.Exceptions;

namespace ChainOfResponsibility.Business
{
    public class FirstNameValidator : BankCreditValidator
    {
        public override void ValidateBankCreditRequest(Account account)
        {
            var isFirstNameValid = !string.IsNullOrEmpty(account.FirstName) && 
                account.FirstName.Length >= BankCreditValidatorConstants.FirstNameMinLength && 
                account.FirstName.Length <= BankCreditValidatorConstants.FirstNameMaxLength;

            if(!isFirstNameValid)
            {
                throw new InvalidFirstNameException(account.FirstName);
            }

            _bankCreditValidator.ValidateBankCreditRequest(account);
        }
    }
}
