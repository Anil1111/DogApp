using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DogApp.Models;

namespace DogApp
{
    public class DogRepository : IDogRepository
    {
        public Dog FindById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Dog> GetAll()
        {
            return new List<Dog>()
            {
                new Dog() {Id = 1, Name = "Kujo"},
                new Dog() {Id = 2, Name = "Shoober"},
                new Dog() {Id = 3, Name = "Fido"},
            };
        }
    }
}
