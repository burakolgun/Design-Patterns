using CommandPatternSample.Business.Commands;
using CommandPatternSample.Data.Entities;

namespace CommandPatternSample.Business.Queries
{
    public interface IQueryCommand
    {
        void Execute(ICommand command, Cart cart);
    }
}
