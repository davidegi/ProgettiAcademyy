using MarioTask.Models;

namespace MarioTask.DTO
{
    public class TeamUserDTO
    {
        public string? Cod { get; set; }
        public string? TNam { get; set; } = null!;
        public string? Bud { get; set; }
        public List<TeamUser> Teams { get; set; } = new List<TeamUser>();

    }
}
