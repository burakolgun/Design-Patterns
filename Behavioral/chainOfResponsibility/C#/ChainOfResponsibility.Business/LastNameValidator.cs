using ChainOfRespobility.Data;
using ChainOfRespobility.Data.Constants;
using ChainOfResponsibility.Business.Exceptions;

namespace ChainOfResponsibility.Business
{
    public class LastNameValidator : BankCreditValidator
    {
        public override void ValidateBankCreditRequest(Account account)
        {
            var isLastNameValid = !string.IsNullOrEmpty(account.LastName) &&
                account.LastName.Length >= BankCreditValidatorConstants.LastNameMinLength &&
                account.LastName.Length <= BankCreditValidatorConstants.LastNameMaxLength;

            if(!isLastNameValid)
            {
                throw new InvalidLastNameException(account.LastName);
            }

            _bankCreditValidator.ValidateBankCreditRequest(account);
        }
    }
}
