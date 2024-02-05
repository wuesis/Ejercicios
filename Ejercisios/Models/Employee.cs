using System;
namespace Ejercisios.Models
{
	public class Employee: IPerson
	{

        public Employee(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
            Salary = 100;
        }

        public int Id { get; set; }

		public string Name { get; set; }

        decimal Salary { get; set; }
    }
}

