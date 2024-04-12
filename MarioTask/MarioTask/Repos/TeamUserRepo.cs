
using MarioTask.Models;

namespace MarioTask.Repos
{
    public class TeamUserRepo : IRepo<TeamUser>
    {
        private readonly MarioDBContext _context;
        public TeamUserRepo(MarioDBContext context)
        {
            _context = context;
        }
        public bool Create(TeamUser entity)
        {
            try
            {
                _context.TeamUsers.Add(entity);
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
                TeamUser? temp = Get(id);
                if (temp != null)
                {
                    _context.TeamUsers.Remove(temp);
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
                TeamUser? temp = GetByCod(cod);
                if (temp != null)
                {
                    _context.TeamUsers.Remove(temp);
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

        public TeamUser? Get(int id)
        {
            return _context.TeamUsers.Find(id);
        }

        public IEnumerable<TeamUser> GetAll()
        {
            return _context.TeamUsers.ToList();
        }

        public bool Update(TeamUser entity)
        {
            try
            {
                _context.TeamUsers.Update(entity);
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
        public TeamUser? GetByCod(string cod)
        {
            try
            {
                return _context.TeamUsers.FirstOrDefault(p => p.Code == cod);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
    }
}
