using NasaInfo.Models;

namespace NasaInfo.Repositories
{
    public class OggettoRepo : IRepo<OggettoCeleste>
    {

        private readonly NasaContext _context;

        public OggettoRepo(NasaContext context)
        {
            _context = context;
        }
        public bool Create(OggettoCeleste entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public OggettoCeleste? Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OggettoCeleste> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(OggettoCeleste entity)
        {
            throw new NotImplementedException();
        }
    }
}
