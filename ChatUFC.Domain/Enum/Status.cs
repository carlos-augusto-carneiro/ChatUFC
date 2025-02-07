using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUFC.Domain.Enum;

public enum Status
{
    Active,     // Conversa em andamento
    Closed,     // Conversa finalizada pelo usuário/sistema
    Archived,   // Conversa arquivada após algum tempo
    Pending     // Aguardando resposta do usuário (opcional)
}
