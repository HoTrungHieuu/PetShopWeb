using PetShop_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop_Repository.Repository
{
    public interface IPetRepository
    {
        List<Pet> GetAllPet();
        Pet GetPetById(int id);
        void AddPet(Pet pet);
        void UpdatePet(Pet pet);
        void DeletePet(Pet pet);
        void DeletePet(int id);
        List<PetGroup> GetAllPetGroup();
    }
}
