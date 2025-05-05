using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class NotificationBuilder : IBuilder
    {
        private Notification _notify;

        public NotificationBuilder()
        {
            Reset();
        }
        public void SetDestinatario(string destinatario)
        {
            _notify.Destinatario = destinatario;
        }
        public void Reset()
        {
            _notify = new Notification();
        }
        
        public void SetTitulo(string titulo)
        {
            _notify.Titulo = titulo;
        }
        public void SetCorpo(string corpo)
        {
            _notify.Corpo = corpo;
        }
        public void SetAssunto(string assunto)
        {
            _notify.Assunto = assunto;
        }
        public void SetRemetente(string remetente)
        {
            _notify.Remetente = remetente;
        }
        public void SetAnexo(string anexo)
        {
            _notify.Anexo = anexo;
        }
        public void SetPrioridade(string prioridade)
        {
            _notify.Prioridade = prioridade;
        }
        public Notification GetNotification()
        {
            return _notify;
        }
    }
