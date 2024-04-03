using GestioneFerramenta.Models;

namespace GestioneFerramenta.Repositories
{
    public class FerraRepo : IRepo<Ferramentum>
    {
        private static FerraRepo _instance;
        public static FerraRepo getIstance()
        {
            if (_instance == null)
                _instance = new FerraRepo();
            return _instance;
        }


        // CRUD: Elimina Prodotto
        public bool delete(int id)
        {
            bool risultato = false;
            using (FerramentaDbContext ctx = new FerramentaDbContext())
            {
                try
                {
                    Ferramentum fer = ctx.Ferramenta.Single(c => c.FerramentaId == id);
                    ctx.Ferramenta.Remove(fer);
                    ctx.SaveChanges();

                    risultato = true;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return risultato;
        }

        // Stampa Prodotti
        public List<Ferramentum> GetAll()
        {
            List<Ferramentum> elenco = new List<Ferramentum>();
            using (FerramentaDbContext ctx = new FerramentaDbContext())
            {
                elenco = ctx.Ferramenta.ToList();
            }
            return elenco;
        }

        // CRUD: Stampa singolo prodotto
        public Ferramentum? GetById(int id)
        {
            Ferramentum? fer = null;
            using (FerramentaDbContext ctx = new FerramentaDbContext())
                fer = ctx.Ferramenta.FirstOrDefault(f => f.FerramentaId == id);
            return fer;
        }

        // CRUD: Crea nuovo prodotto
        public bool insert(Ferramentum t)
        {
            bool risultato = false;
            using (FerramentaDbContext ctx = new FerramentaDbContext())
            {
                try
                {
                    ctx.Ferramenta.Add(t);
                    ctx.SaveChanges();

                    risultato = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return risultato;
        }

        // CRUD: update
        public bool update(Ferramentum t)
        {
            bool risultato = false;

            using (FerramentaDbContext ctx = new FerramentaDbContext())
            {
                try
                {
                    Ferramentum temp = ctx.Ferramenta.Single(f => f.Codice == t.Codice);

                    t.FerramentaId = temp.FerramentaId;
                    t.Codice = t.Codice is not null ? t.Codice : temp.Codice;
                    t.Nome = t.Nome is not null ? t.Nome : temp.Nome;
                    t.Descrizione = t.Descrizione is not null ? t.Descrizione : temp.Descrizione;
                    t.Prezzo = t.Prezzo == 0 ? temp.Prezzo : t.Prezzo;
                    t.Quantita = temp.Quantita;
                    t.Categoria = t.Categoria is null ? temp.Categoria : t.Categoria;
                    t.Creazione = t.Creazione is null ? temp.Creazione : t.Creazione;

                    ctx.Entry(temp).CurrentValues.SetValues(t);

                    ctx.SaveChanges();

                    risultato = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return risultato;
        }
        // Stampa dettaglio per codice
        public Ferramentum? GetByCodice(string codice)
        {
            Ferramentum? fer = null;

            using (FerramentaDbContext ctx = new FerramentaDbContext())
                fer = ctx.Ferramenta.FirstOrDefault(f => f.Codice == codice);

            return fer;
        }
    }
}