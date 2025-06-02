using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class WhatsappNotifierDecorator : NotifierDecorator
    {
        public WhatsappNotifierDecorator(INotifier notifier) : base(notifier) { }

        public override string Send(string message)
        {
            string baseNotification = base.Send(message); // Chama o Send() do objeto embrulhado
            string WhatsappNotification = $"Whatsapp enviado: {message}";

            // Concatena a notificação base com a nova funcionalidade
            // Verifica se baseNotification não é vazia para evitar linhas em branco desnecessárias
            // se o Send() do wrappedNotifier retornasse string.Empty por algum motivo.
            if (!string.IsNullOrEmpty(baseNotification))
            {
                return $"{baseNotification}\n{WhatsappNotification}";
            }
            return WhatsappNotification;
        }
    }
}
