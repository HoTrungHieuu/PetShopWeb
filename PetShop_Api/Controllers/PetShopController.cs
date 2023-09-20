using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShop_Repository.Models;
using PetShop_Repository.Repository;

namespace PetShop_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetShopController : ControllerBase
    {

        private IPetRepository _petRepository = new PetRepository();
        
        [HttpGet("ListPet")]
        public List<Pet> GetAllPet()
        {
            return _petRepository.GetAllPet();
        }
        [HttpGet("Pet{{id}}")]
        public Pet GetPet(int id)
        {
            return GetAllPet().FirstOrDefault(p=>p.PetId==id);
        }

        [HttpGet("ListGroupPet")]
        public List<PetGroup> GetAllPetGroup()
        {
            return _petRepository.GetAllPetGroup();
        }

        [HttpPost("AddPet")]
        public void AddPet(Pet pet)
        {
            Pet _pet = new()
            {
                PetId = GetAllPet().Count() + 1,
                PetName = pet.PetName,
                ImportDate = pet.ImportDate,
                PetDescription = pet.PetDescription,
                Quantity = pet.Quantity,
                PetPrice= pet.PetPrice,
                PetGroupId = pet.PetGroupId,
            };
            _petRepository.AddPet(_pet);
        }

        [HttpPut("UpdatePet{{id}}")]
        public void UpdatePet(int id,Pet pet)
        {
            Pet _pet = GetAllPet().FirstOrDefault(p => p.PetId == id);
            if (_pet == null) return;
            _pet.PetName = pet.PetName;
            _pet.ImportDate = pet.ImportDate;
            _pet.PetDescription = pet.PetDescription;
            _pet.PetPrice = pet.PetPrice;
            _pet.Quantity = pet.Quantity;
            _pet.PetGroupId = pet.PetGroupId;
            _petRepository.UpdatePet(_pet);
            
        }

        [HttpDelete(("DeletePet{{id}}"))]
        public void DeletePet(int id)
        {
            Pet _pet = GetAllPet().FirstOrDefault(p => p.PetId == id);
            if (_pet == null) return;
            petIdRefress(_pet.PetId);
            _petRepository.DeletePet(GetAllPet().FirstOrDefault(p => p.PetId == GetAllPet().Count));
        }
        private void petIdRefress(int id)
        {
            int count = GetAllPet().Count;
            for (int i = id; i < count; i++)
            {
                var pet = GetAllPet().FirstOrDefault(p => p.PetId == i);
                pet.PetName = GetAllPet().FirstOrDefault(p => p.PetId == i + 1).PetName;
                pet.ImportDate = GetAllPet().FirstOrDefault(p => p.PetId == i + 1).ImportDate;
                pet.PetDescription = GetAllPet().FirstOrDefault(p => p.PetId == i + 1).PetDescription;
                pet.Quantity = GetAllPet().FirstOrDefault(p => p.PetId == i + 1).Quantity;
                pet.PetPrice = GetAllPet().FirstOrDefault(p => p.PetId == i + 1).PetPrice;
                pet.PetGroupId = GetAllPet().FirstOrDefault(p => p.PetId == i + 1).PetGroupId;
                _petRepository.UpdatePet(pet);
            }

        }
    }
}
