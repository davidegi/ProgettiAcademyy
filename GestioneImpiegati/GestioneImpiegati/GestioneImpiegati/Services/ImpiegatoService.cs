using GestioneImpiegati.Models;
using GestioneImpiegati.Repositories;

namespace GestioneImpiegati.Services
{
    public class ImpiegatoService
    {
        private readonly ImpiegatoRepository _repository;
        public ImpiegatoService(ImpiegatoRepository repo)
        {
            _repository = repo;
        }

        public List<Impiegato> ElencoTuttiImpiegati()
        {
            return _repository.GetAll();
        }

        public bool InserisciImpiegato(Impiegato imp)
        {
            return _repository.Insert(imp);
        }

        public Impiegato? RicercaImpiegatoPerMatricola(string varMatricola)
        {
            return _repository.GetByMatricola(varMatricola);
        }

        public bool EliminaImpiegatoPerMatricola(string varMatricola)
        {
            Impiegato? temp = _repository.GetByMatricola(varMatricola);
            if (temp == null)
                return false;

            return _repository.Delete(temp.ImpiegatoId);
        }

        /*public bool ModificaImpiegato(Impiegato vecchio, Impiegato nuovo)
        {
            vecchio.Nome = nuovo.Nome;
            vecchio.Descrizione = nuovo.Descrizione;
            //...

            return _repository.Update(vecchio);
        }*/
    }
}
