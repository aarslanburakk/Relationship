using System.Text.Json.Serialization;

namespace Releationship.Models
{
    public class PlayerStat
    {
        [JsonIgnore]
        public Guid Id { get; set; } = Guid.NewGuid();
        public int STR { get; set; } = 50;
        public int HP { get; set; } = 50;
        public int DEX { get; set; } = 50;
        public int INT { get; set; } = 50;
        [JsonIgnore]
        public Guid PlayerId { get; set; }
        
        [JsonIgnore]
        public Player Player { get; set; }

    }
}
