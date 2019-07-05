using ChainOfRespobility.Data;

namespace ChainOfResponsibility.Business
{
    public abstract class BankCreditValidator
    {
        protected BankCreditValidator _bankCreditValidator;
        public void SetSuccessor(BankCreditValidator bankCreditValidator)
        {
            _bankCreditValidator = bankCreditValidator;
        }

        public abstract void ValidateBankCreditRequest(Account purchase);
    }
}
