using System;
using System.Collections.Generic;

namespace PetShop_Repository.Models
{
    public partial class PetGroup
    {
        public PetGroup()
        {
            Pets = new HashSet<Pet>();
        }

        public string PetGroupId { get; set; } = null!;
        public string PetGroupName { get; set; } = null!;
        public string? GroupDescription { get; set; }
        public string? OriginalSource { get; set; }

        public virtual ICollection<Pet> Pets { get; set; }
    }
}
