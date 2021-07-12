using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace entities
{
    public class ClientsContext : DbContext
    {
        public DbSet<Client> Clients;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //mexer aqui
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=Blogging;Integrated Security=True");
        }
    }
    public class Client
    {
        public readonly Guid id;
        public string name;
        public string cnpj;
        public DateTime createdAt;
        public DateTime updatedAt;
        public List<Contact> contacts;
        public List<Address> addresses;
        public Client(
        string name, string cnpj, List<Address> addresses, List<Contact> contacts, 
        Guid id = new Guid(), DateTime createdAt = new DateTime(),
        DateTime updatedAt = new DateTime()){
            this.name = name;
            this.cnpj = cnpj;
            this.contacts = contacts;
            this.addresses = addresses;
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
