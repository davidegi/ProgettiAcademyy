namespace MarioTask.Models
{
    public class CharacterUser
    {
        public int CharacterID { get; set; }
        public string Code { get; set; } = Guid.NewGuid().ToString();
        public string? CharacterName { get; set; }
        public string? Category { get; set; }
        public int Credit { get; set; }
        public int? TeamUserRIF { get; set; }
        public TeamUser? TeamUserRIFNavigation { get; set; }
    }
}
