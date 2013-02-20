using System;

namespace ES.Lab.Commands
{
    public class JoinGameCommand : ICommand
    {
        public JoinGameCommand(Guid entityId, string playerId)
        {
            PlayerId = playerId;
            EntityId = entityId;
        }

        public string PlayerId { get; private set; }
        public Guid EntityId { get; private set; }

    }
}