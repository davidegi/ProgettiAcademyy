using NasaInfo.Models;

namespace NasaInfo.Repositories
{
    public class SistemaRepo : IRepo<Sistema>
    {
        private readonly NasaContext _context;

        public SistemaRepo(NasaContext context)
        {
            _context = context;
        }
        public bool Create(Sistema entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Sistema? Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Sistema> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Sistema entity)
        {
            throw new NotImplementedException();
        }
    }
}
