using PetShop_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop_Repository.DAO
{
    public class MemberDbContext
    {
        private readonly PetShop2023DBContext _context = new();

        public PetShopMember GetMemberById(string id)
        {
            return _context.PetShopMembers.FirstOrDefault(m => m.MemberId.Equals(id));

        }
        public List<PetShopMember> GetAllMember()
        {
            return _context.PetShopMembers.ToList();
        }
    }
}
