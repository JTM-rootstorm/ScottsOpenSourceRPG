using Engine.Entities;

namespace Engine
{
    public class PlayerSession
    {
        public Game Game { get; private set; }
        public Player Player { get; private set; }

        public PlayerSession(Game game)
        {
            Game = game;
        }

        public void SetPlayer(Player player)
        {
            Player = player;
        }
    }
}
