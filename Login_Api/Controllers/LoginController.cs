using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShop_Repository.Repository;
using PetShop_Repository.Models;

namespace Login_Api.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        
        IMemberRepository _memberRepository= new MemberRepository();
        [HttpPost]
        public bool accountLogin(string email,string password)
        {
            PetShopMember member = _memberRepository.GetMembers().FirstOrDefault(m=>m.EmailAddress.Equals(email) && m.MemberPassword.Equals(password));
            if (member == null)
            {
                return false;
            }
            return true;
        }
    }
}
