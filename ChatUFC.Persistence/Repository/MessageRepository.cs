using ChatUFC.Domain.Interface;
using ChatUFC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUFC.Persistence.Repository;

public class MessageRepository : IMessage
{
    public Task AddAsync(Message entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Message>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Message>> GetByConversationIdAsync(Guid conversationId)
    {
        throw new NotImplementedException();
    }

    public Task<Message> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Message>> GetLastMessagesAsync(int count)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Guid id, Message entity)
    {
        throw new NotImplementedException();
    }
}
