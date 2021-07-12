using System;
using System.ComponentModel.DataAnnotations;

namespace entities
{
    public class Client
    {
        public readonly Guid id;
        public string name;
        public string cnpj;
        public DateTime createdAt;
        public DateTime updatedAt;
        public Contact contact;
        public Address address;
        public Client(
        string name, string cnpj, Address address, Contact contact, 
        Guid id = new Guid(), DateTime createdAt = new DateTime(),
        DateTime updatedAt = new DateTime()){
            this.name = name;
            this.cnpj = cnpj;
            this.contact = contact;
            this.address = address;
            if(id == new Guid()){
                this.id = Guid.NewGuid();
                this.createdAt = DateTime.Now;
                this.updatedAt = DateTime.Now;
                return;
            }
            this.id = id;
            this.createdAt = createdAt;
            this.updatedAt = updatedAt;
        }
    }
}
