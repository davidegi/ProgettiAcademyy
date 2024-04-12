using MarioTask.DTO;
using MarioTask.Models;
using MarioTask.Repos;

namespace MarioTask.Services
{
    public class CharacterUserService
    {
        private readonly CharacterUserRepo _repository;

        public CharacterUserService(CharacterUserRepo repository)
        {
            _repository = repository;
        }

        public List<CharacterUserDTO> GetAllCharacter()
        {
            List<CharacterUserDTO> clist = _repository.GetAll().Select(c => new CharacterUserDTO()
            {
                Cod = c.Code,
                CNam = c.CharacterName,
                Cat = c.Category,
                Cred = c.Credit,
            }).ToList();

            return clist;
        }

        public bool InsertCharacter(CharacterUserDTO c)
        {
            CharacterUser charac = new CharacterUser()
            {
                Code = c.Cod,
                CharacterName = c.CNam,
                Category = c.Cat,
                Credit = c.Cred
            };

            return _repository.Create(charac);
        }
        public bool UpdateCharacter(CharacterUserDTO c)
        {
            if (c.Cod != null)
            {
                CharacterUser? charac = _repository.GetByCod(c.Cod);
                if (charac != null)
                {
                    charac.CharacterName = c.CNam;
                    charac.Category = c.Cat;
                    charac.Credit = c.Cred;

                    return _repository.Update(charac);
                }
            }
            return false;
        }
    }
}
