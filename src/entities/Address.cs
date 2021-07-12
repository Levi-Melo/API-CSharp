using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
namespace entities
{

    public class AddressesContext : DbContext
    {
        public DbSet<Address> Addresses;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //mexer aqui
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=Blogging;Integrated Security=True");
        }
    }
    public class Address
    {
        public readonly Guid id;
        public readonly Guid clientId;
        public string street;
        public int number;
        public string district;
        public string city;
        public string state;
        public string cep;
        public DateTime createdAt;
        public DateTime updatedAt;

        public Address(
            Guid clientId, string street, int number,string district,
            string city,string state,string cep,Guid id = new Guid(), 
            DateTime createdAt = new DateTime(), 
            DateTime updatedAt = new DateTime()){
                this.street = street;
                this.clientId = clientId;
                this.number = number;
                this.district = district;
                this.city = city;
                this.state = state;
                this.cep = cep;
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
