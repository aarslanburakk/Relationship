using System.Text.Json.Serialization;

namespace Releationship.Models
{
    public class Player
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public PlayerStat PlayerStat { get; set; }
        public List<PlayerItem> PlayerItems { get; set; }



    }
}
