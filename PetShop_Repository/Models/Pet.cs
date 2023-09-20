using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PetShop_Repository.Models
{
    public partial class Pet
    {
        [JsonIgnore]
        public int PetId { get; set; }
        public string PetName { get; set; } = null!;
        public DateTime? ImportDate { get; set; }
        public string? PetDescription { get; set; }
        public int? Quantity { get; set; }
        public double? PetPrice { get; set; }
        public string? PetGroupId { get; set; }
        [JsonIgnore]
        public virtual PetGroup? PetGroup { get; set; }
    }
}
