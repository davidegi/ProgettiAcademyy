
using MarioTask.Models;

namespace MarioTask.Repos
{
    public class CharacterUserRepo : IRepo<CharacterUser>
    {

        private readonly MarioDBContext _context;

        public CharacterUserRepo(MarioDBContext context)
        {
            _context = context;
        }
        public bool Create(CharacterUser entity)
        {
            try
            {
                _context.CharacterUsers.Add(entity);
                _context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                CharacterUser? temp = Get(id);
                if (temp != null)
                {
                    _context.CharacterUsers.Remove(temp);
                    _context.SaveChanges();

                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return false;
        }

        // DTO Only
        public bool DeleteByCode(string cod)
        {
            try
            {
                CharacterUser? temp = GetByCod(cod);
                if (temp != null)
                {
                    _context.CharacterUsers.Remove(temp);
                    _context.SaveChanges();

                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return false;
        }
        public CharacterUser? Get(int id)
        {
            return _context.CharacterUsers.Find(id);
        }

        public IEnumerable<CharacterUser> GetAll()
        {
            return _context.CharacterUsers.ToList();
        }

        public bool Update(CharacterUser entity)
        {
            try
            {
                _context.CharacterUsers.Update(entity);
                _context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        // DTO Only
        public CharacterUser? GetByCod(string cod)
        {
            try
            {
                return _context.CharacterUsers.FirstOrDefault(p => p.Code == cod);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
    }
}
