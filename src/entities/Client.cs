using System;
using System.ComponentModel.DataAnnotations;

namespace entities
{
    public class Client
    {
        [Required]
        public Guid id;
        [Required]
        public string name;
        [Required]
        public string cnpj;
        [Required]
        public DateTime createdAt;
        [Required]
        public DateTime updatedAt;
        public Contact contact;
        public Address address;
        public Client( Guid id, string name, string cnpj, DateTime createdAt = new DateTime(),
         Address address = null, Contact contact = null){
            this.name = name;
            this.cnpj = cnpj;
            this.id = id;
            this.createdAt = createdAt;
            this.contact = contact;
            this.address = address;
        }
    }
}
