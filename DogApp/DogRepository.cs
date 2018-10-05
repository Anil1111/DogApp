using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DogApp.Models;

namespace DogApp
{
    public class DogRepository : IDogRepository
    {
        Dictionary<int, Dog> allDogs = new Dictionary<int, Dog>()
        {
            { 1, new Dog() {Id = 1, Name = "Kujo"} },
            { 2, new Dog() {Id = 2, Name = "Shoober"} },
            { 3, new Dog() {Id = 3, Name = "Fido"} },
        };

        public Dog FindById(int id)
        {
            return allDogs[id];
        }

        public List<Dog> GetAll()
        {
            return allDogs.Values.ToList();
        }
    }
}
