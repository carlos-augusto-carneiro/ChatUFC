using ChatUFC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUFC.Domain.Interface;

public interface IMessage : IRepository<Message>
{
    Task<IEnumerable<Message>> GetByConversationIdAsync(Guid conversationId);
    Task<IEnumerable<Message>> GetLastMessagesAsync(int count);
}
