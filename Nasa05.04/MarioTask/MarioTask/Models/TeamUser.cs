namespace MarioTask.Models
{
    public class TeamUser
    {
        public int TeamUserID { get; set; }
        public string Code { get; set; } = Guid.NewGuid().ToString();
        public string? TeamName { get; set; }
        public int Budget { get; set; } = 10;
        public ICollection<CharacterUser> CharacterList { get; } = new List<CharacterUser>();
    }
}
