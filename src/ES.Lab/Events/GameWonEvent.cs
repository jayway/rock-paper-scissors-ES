using System;

namespace ES.Lab.Events
{
    public class GameWonEvent : IEvent
    {

        public GameWonEvent(Guid gameId, string playerId)
        {
            GameId = gameId;
            PlayerId = playerId;
        }

        public Guid GameId { get; set; }
        public string PlayerId { get; private set; }
    }
}