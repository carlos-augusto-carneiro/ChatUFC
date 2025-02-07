using ChatUFC.Domain.Interface;
using ChatUFC.Persistence.Context;
using ChatUFC.Persistence.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUFC.Persistence;

public static class ConfigurationPersistence
{
    public static void ConfigurationPersistenceApp(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("AzureSQL1");
        services.AddDbContext<DbChat>(x => x.UseSqlServer(connectionString));

        services.AddScoped<IUser, UserRepository>();
        services.AddScoped<IMessage, MessageRepository>();
        services.AddScoped<IConversation, ConversationRepository>();

    }
}
