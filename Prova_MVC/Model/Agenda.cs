using System.Collections.Generic;

namespace Prova_MVC.Model
{
    public class Agenda
    {
        // Convenção C#: usar _ para campos privados
        private readonly List<Contato> _contatos;

        public Agenda()
        {
            _contatos = new List<Contato>();
        }

        public void AdicionarContato(Contato contato)
        {
            if (contato != null)
            {
                _contatos.Add(contato);
            }
        }

        public List<Contato> GetContatos()
        {
            // Retorna uma nova lista para proteger a lista interna de modificações
            return new List<Contato>(_contatos);
        }
    }
}
