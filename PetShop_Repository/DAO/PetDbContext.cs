using PetShop_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop_Repository.DAO
{
    public class PetDbContext
    {
        private readonly PetShop2023DBContext _context = new();

        public Pet GetPetById(int id)
        {
            return _context.Pets.FirstOrDefault(m => m.PetId == id);

        }
        public List<Pet> GetAllPet()
        {
            return _context.Pets.ToList();
        }
        public void UpdatePet(Pet pet)
        {
            _context.Pets.Update(pet);
            _context.SaveChanges();
        }
        public void DeletePet(int id)
        {
            var pet = _context.Pets.FirstOrDefault(p => p.PetId == id);
            if (pet != null)
            {
                _context.Pets.Remove(pet);
                _context.SaveChanges();
            }

        }

        public void AddPet(Pet pet)
        {
            _context.Pets.Add(pet);
            _context.SaveChanges();
        }
        public List<PetGroup> GetAllPetGroup()
        {
            return _context.PetGroups.ToList();
        }
    }
}
