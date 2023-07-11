using System.Text.Json.Serialization;

namespace Releationship.Models
{
    public class PlayerItem
    {
        [JsonIgnore]

        public Guid Id { get; set; }


        public string ItemName { get; set; }


        [JsonIgnore]
        public Guid PlayerId { get; set; }


        [JsonIgnore]
        public Player Player { get; set; }
    }
}
