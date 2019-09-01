using System;
using NewbiePlayer;
using ProPlayer;

namespace Player.Factory
{
    public class PlayerFactory : IPlayerFactory
    {
        public IPlayer GetPlayer(Enum.Type playerType)
        {
            switch (playerType)
            {
                case Enum.Type.Newbie: 
                    return new Newbie();
                case Enum.Type.ProPlayer:
                    return new Proplayer();
                default:
                    throw new NotSupportedException();
            }
        }
        
    }
}