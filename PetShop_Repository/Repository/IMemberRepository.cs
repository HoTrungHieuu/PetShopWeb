using PetShop_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop_Repository.Repository
{
    public interface IMemberRepository
    {
        List<PetShopMember> GetMembers();
        PetShopMember GetMember(string id);
    }
}
