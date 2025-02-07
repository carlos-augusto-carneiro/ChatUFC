using ChatUFC.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUFC.Domain.Models;

public class Conversation
{
    public Guid Id { get; set; }
    public User user { get; set; }
    public Guid UserId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime EndAt { get; set; }
    public Status status { get; set; }

    public ICollection<Message> Messages { get; set; }


}
