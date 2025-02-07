using ChatUFC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUFC.Domain.Interface;

public interface IUser : IRepository<User>
{
    Task<User> GetByEmailAsync(string email);
    Task<User> GetByRegistrationAsync(int registration);
}
