using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    interface IBuilder
    {
        void Reset();

        Notification GetNotification();

        void SetDestinatario(string destinatario);
        void SetTitulo(string titulo);
        void SetCorpo(string corpo);
        void SetAssunto(string assunto);
        void SetRemetente(string remetente);
        void SetAnexo(string anexo);
        void SetPrioridade(string prioridade);
    }
    