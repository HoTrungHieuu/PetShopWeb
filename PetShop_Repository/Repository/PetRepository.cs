using PetShop_Repository.DAO;
using PetShop_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop_Repository.Repository
{
    public class PetRepository : IPetRepository
    {
        PetDbContext _context = new();
        public void AddPet(Pet pet)
        {
            _context.AddPet(pet);
        }

        public void DeletePet(Pet pet)
        {
            DeletePet(pet.PetId);
        }

        public void DeletePet(int id)
        {
            _context.DeletePet(id);
        }

        public List<Pet> GetAllPet()
        => _context.GetAllPet();

        public List<PetGroup> GetAllPetGroup()
        {
            return _context.GetAllPetGroup();
        }

        public Pet GetPetById(int id)
        => _context.GetPetById(id);

        public void UpdatePet(Pet pet)
        => _context.UpdatePet(pet);
    }
}
