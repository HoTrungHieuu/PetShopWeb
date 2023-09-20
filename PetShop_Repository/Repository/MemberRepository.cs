using PetShop_Repository.DAO;
using PetShop_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop_Repository.Repository
{
    public class MemberRepository : IMemberRepository
    {
        MemberDbContext _context = new();
        public List<PetShopMember> GetMembers()
        => _context.GetAllMember();

        public PetShopMember GetMember(string id)
        => _context.GetMemberById(id);
    }
}
