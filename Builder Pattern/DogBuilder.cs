using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    public class DogBuilder
    {
        private Dog _dog;

        public DogBuilder()
        {
            _dog = new Dog();
        }

        public DogBuilder SetName(string name)
        {
            _dog.Name = name;
            return this;
        }

        public DogBuilder SetBreed(string breed)
        {
            _dog.Breed = breed;
            return this;
        }

        public DogBuilder SetAge(int age)
        {
            _dog.Age = age;
            return this;
        }

        public DogBuilder AddToy(string toy)
        {
            _dog.Toys.Add(toy);
            return this;
        }

        public Dog Build()
        {
            return _dog;
        }
    }
}
