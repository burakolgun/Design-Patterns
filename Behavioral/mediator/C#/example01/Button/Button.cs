using example01.Mediator;

namespace example01.Button
{
    public class Button : IButton
    {
        private readonly Mediator.Mediator _mediator = MediatorHelper.GetController();
        
        public void Press()
        {
            _mediator.Press();
        }
    }
}