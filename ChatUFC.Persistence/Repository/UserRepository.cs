using ChatUFC.Domain.Interface;
using ChatUFC.Domain.Models;
using ChatUFC.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ChatUFC.Persistence.Repository;

public class UserRepository : IUser
{
    private readonly DbChat _context;
    private readonly ILogger<UserRepository> _logger;

    public UserRepository(DbChat context, ILogger<UserRepository> logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task AddAsync(User entity)
    {
        await _context.Users.AddAsync(entity);
        await _context.SaveChangesAsync();
        _logger.LogInformation("Usuário {UserId} adicionado com sucesso", entity.Id);
    }

    public async Task DeleteAsync(Guid id)
    {
        try
        {
            var user = await _context.Users.FindAsync(id);
            if (user != null)
            {
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
                _logger.LogInformation($"Usuairo {id} deletado com sucesso");
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error deletar Usuario {id}");
            throw;
        }
    }

    public async Task<IEnumerable<User>> GetAllAsync()
    {
        var users = await _context.Users.AsNoTracking().ToListAsync();
        _logger.LogDebug("Consulta realizada em GetAllAsync, {Count} usuários encontrados", users.Count);
        return users;
    }

    public async Task<User?> GetByEmailAsync(string email)
    {
        var user = await _context.Users.AsNoTracking().FirstOrDefaultAsync(x => x.Email == email);
        if (user == null)
        {
            _logger.LogWarning("Nenhum usuário encontrado com o email {Email}", email);
        }
        else
        {
            _logger.LogDebug("Usuário {UserId} encontrado para o email {Email}", user.Id, email);
        }
        return user;
    }

    public async Task<User?> GetByIdAsync(Guid id)
    {
        return await _context.Users.FindAsync(id);
    }

    public async Task<User?> GetByRegistrationAsync(int registration)
    {
        return await _context.Users.AsNoTracking().FirstOrDefaultAsync(x => x.Registration == registration);
    }

    public async Task UpdateAsync(Guid id, User entity)
    {
        var user = await _context.Users.FindAsync(id);
        if (user != null)
        {
            _context.Users.Update(entity);
            await _context.SaveChangesAsync();
            _logger.LogInformation("Usuário {UserId} atualizado com sucesso", id);
            return;
        }
        _logger.LogWarning("Usuário {UserId} não encontrado para atualização", id);
        throw new Exception("User não encontrado");
    }

    public void Dispose()
    {
        _context.Dispose();
        GC.SuppressFinalize(this);
    }
}
