using ChainOfRespobility.Data;

namespace ChainOfResponsibility.Business
{
    public interface IBankCreditValidator
    {
        void ValidateBankCreditRequest(Account account);
    }
}
