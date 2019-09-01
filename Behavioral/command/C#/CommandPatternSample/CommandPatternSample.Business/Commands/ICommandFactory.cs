using CommandPatternSample.Data.Enums;

namespace CommandPatternSample.Business.Commands
{
    public interface ICommandFactory
    {
        ICommand GetCommand(CartOperationEnum cartOperationEnum);
    }
}
