using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUFC.Domain.Enum;

public enum Sender
{
    User,       // Mensagem enviada pelo usuário
    Bot,        // Resposta do chatbot
    System      // Mensagens automáticas do sistema (ex: confirmações, notificações)
}
