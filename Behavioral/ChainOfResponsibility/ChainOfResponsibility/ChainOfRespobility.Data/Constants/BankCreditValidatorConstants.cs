using ChainOfRespobility.Data.Enums;
using System.Collections.Generic;

namespace ChainOfRespobility.Data.Constants
{
    public static class BankCreditValidatorConstants
    {
        public static int FirstNameMinLength = 3;
        public static int FirstNameMaxLength = 25;
        public static int LastNameMinLength = 3;
        public static int LastNameMaxLength = 100;


        public static Dictionary<BankCreditRequestEnum, Dictionary<int, int>> ageRulesDictionary = new Dictionary<BankCreditRequestEnum, Dictionary<int, int>>
        {
            { BankCreditRequestEnum.Financial, new Dictionary<int, int>{ { 25, 65 } } },
            { BankCreditRequestEnum.Mortgage, new Dictionary<int, int>{ { 20, 45 } } },
            { BankCreditRequestEnum.IndividualLoan, new Dictionary<int, int>{ { 18, 50 } } },
        };
    }
}
