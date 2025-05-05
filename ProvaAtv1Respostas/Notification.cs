using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Notification
    {
        public string Destinatario { get; set; }
        public string Corpo { get; set; }
        public string Titulo { get; set; }
        public string Assunto { get; set; }
        public string Remetente { get; set; }
        public string Anexo { get; set; }
        public string Prioridade { get; set; }

        /*
        public Notification(string destinatario, string corpo,
        string titulo, string assunto, string remetente,
        string anexo, string prioridade)
        {
            Destinatario = destinatario;
            Corpo = corpo;
            Titulo = titulo;
            Assunto = assunto;
            Remetente = remetente;
            Anexo = anexo;
            Prioridade = prioridade;
        }*/

        public Notification(string destinatario, string corpo,
        string titulo=null, string assunto=null, string remetente=null,
        string anexo=null, string prioridade=null)
        {
            Destinatario = destinatario;
            Corpo = corpo;
            Titulo = titulo;
            Assunto = assunto;
            Remetente = remetente;
            Anexo = anexo;
            Prioridade = prioridade;
        }

        public Notification()
        {
        }

        public override string ToString()
        {
            return $"\nDestinatário: {Destinatario}, Corpo: {Corpo}, Titulo: {Titulo}, Assunto: {Assunto}, Remetente: {Remetente}, Anexo: {Anexo}, Prioridade: {Prioridade}";
        }
    }
