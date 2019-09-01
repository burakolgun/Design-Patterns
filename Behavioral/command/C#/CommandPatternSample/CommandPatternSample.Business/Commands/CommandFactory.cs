using CommandPatternSample.Data.Enums;
using System;

namespace CommandPatternSample.Business.Commands
{
    public class CommandFactory : ICommandFactory
    {
        public ICommand GetCommand(CartOperationEnum cartOperationEnum)
        {
            switch (cartOperationEnum)
            {
                case CartOperationEnum.Create:
                    return new CreateCommand();
                case CartOperationEnum.Delete:
                    return new DeleteCommand();
                default:
                    throw new ArgumentException($"{nameof(cartOperationEnum)} is invalid command");
            }
        }
    }
}
