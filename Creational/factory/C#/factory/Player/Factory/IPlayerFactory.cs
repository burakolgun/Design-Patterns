namespace Player.Factory
{
    public interface IPlayerFactory
    {
        IPlayer GetPlayer(Enum.Type playerType);
    }
}