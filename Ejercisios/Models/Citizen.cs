using System;
namespace Ejercisios.Models
{
    public class Citizen : IPerson
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool spareTime { get; set; }


        public Citizen(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
            spareTime = true;
        }
    }
}

