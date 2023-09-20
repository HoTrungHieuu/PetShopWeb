using System;
using System.Collections.Generic;

namespace PetShop_Repository.Models
{
    public partial class PetShopMember
    {
        public string MemberId { get; set; } = null!;
        public string MemberPassword { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public string? EmailAddress { get; set; }
        public int? MemberRole { get; set; }
    }
}
