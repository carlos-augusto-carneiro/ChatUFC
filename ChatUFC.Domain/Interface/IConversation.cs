using ChatUFC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUFC.Domain.Interface;

public interface IConversation : IRepository<Conversation>
{
    Task<IEnumerable<Conversation>> GetByUserIdAsync(Guid userId);
    Task<IEnumerable<Conversation>> GetActiveConversationsAsync();
    Task CloseConversationAsync(Guid conversationId);
}
