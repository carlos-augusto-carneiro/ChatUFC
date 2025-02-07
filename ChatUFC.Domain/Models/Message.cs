using ChatUFC.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUFC.Domain.Models;

public class Message
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public Conversation Conversation { get; set; }
    public Guid ConversationId { get; set; }
    public Sender PostMessage { get; set; }
    public string Content { get; set; }
    public DateTime Created { get; set; }
}
