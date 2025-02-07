using ChatUFC.Domain.Interface;
using ChatUFC.Domain.Models;
using ChatUFC.Persistence.Context;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUFC.Persistence.Repository;

public class ConversationRepository : IConversation
{
    private readonly DbChat _context;
    private readonly ILogger<ConversationRepository> _logger;

    public ConversationRepository(DbChat context, ILogger<ConversationRepository> logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task AddAsync(Conversation entity)
    {
        await _context.Conversations.AddAsync(entity);
        await _context.SaveChangesAsync();
        _logger.LogInformation($"Criada nova conversa");
    }

    public Task CloseConversationAsync(Guid conversationId)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteAsync(Guid id)
    {
        var conversation = await _context.Conversations.FindAsync(id);
        if (conversation != null)
        {
            _context.Conversations.Remove(conversation);
            await _context.SaveChangesAsync();
        }
        throw new Exception("Não encontrada");
    }

    public Task<IEnumerable<Conversation>> GetActiveConversationsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Conversation>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Conversation> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Conversation>> GetByUserIdAsync(Guid userId)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Guid id, Conversation entity)
    {
        throw new NotImplementedException();
    }
}
