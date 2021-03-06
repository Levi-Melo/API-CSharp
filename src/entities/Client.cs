using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace entities
{
    public class ClientsContext : DbContext
    {
        public DbSet<Client> Clients{ get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=api_csharp;user=SA;Password=Azxs1230");
        }
    }
    public class Client
    {
        [KeyAttribute]
        public readonly Guid id;
        public string name;
        [CustomValidation(typeof(CustomValidators),"CnpjValidation")]
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
            this.id = id == new Guid() ? Guid.NewGuid() : id;
            this.createdAt = createdAt == new DateTime() ? DateTime.Now : createdAt;
            this.updatedAt = updatedAt == new DateTime() ? DateTime.Now : updatedAt;
        }
    }
}
