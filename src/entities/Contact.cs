using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
namespace entities
{
    public class ContactsContext : DbContext
    {
    public DbSet<Contact> Contacts;
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //mexer aqui
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=Blogging;Integrated Security=True");
        }
    }
    public class Contact
    {
        public readonly Guid id;
        public readonly Guid clientId;
        public string telephone;
        public string cellphone ;
        public string contactName ;
        public string email;
        public DateTime createdAt;
        public DateTime updatedAt;
        public Contact(
            Guid clientId,string telephone, string cellphone , 
            string contactName , string email, Guid id = new Guid(),
            DateTime createdAt = new DateTime(),
            DateTime updatedAt = new DateTime()){
                this.clientId = clientId;
                this.telephone = telephone;
                this.cellphone= cellphone;
                this.contactName = contactName;
                this.email = email;
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
