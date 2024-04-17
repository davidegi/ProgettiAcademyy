using GestioneImpiegati.Models;

namespace GestioneImpiegati.Repositories
{
    public class ImpiegatoRepository : IRepo<Impiegato>
    {
        private readonly GimpiegatoDbContext _context;
        public ImpiegatoRepository(GimpiegatoDbContext ctx)
        {
            _context = ctx;
        }
        public bool Delete(int id)
        {
            try
            {
                Impiegato temp = _context.Impiegatos.Single(p => p.ImpiegatoId == id);
                _context.Impiegatos.Remove(temp);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return false;
        }

        public List<Impiegato> GetAll()
        {
            return _context.Impiegatos.ToList();
        }

        public Impiegato? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Impiegato? GetByMatricola(string varMatricola)
        {
            Impiegato? tmp = null;
            try
            {
                tmp = _context.Impiegatos.FirstOrDefault(i => i.Matricola == varMatricola);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return tmp;
        }

        public bool Insert(Impiegato t)
        {
            try
            {
                _context.Impiegatos.Add(t);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return false;
        }

        public bool Update(Impiegato t)
        {
            try
            {
                _context.Update(t);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return false;
        }
    }
}
