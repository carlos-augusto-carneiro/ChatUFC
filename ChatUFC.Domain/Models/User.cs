using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUFC.Domain.Models;

public class User
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public int Registration {  get; set; }
    public DateTime DateCreating { get; set; }
    public ICollection<Conversation> Conversations { get; set; }

}
