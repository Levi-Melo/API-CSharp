using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace entities
{
    public class ContactsContext : DbContext
    {
    public DbSet<Contact> Contacts;
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
            @"Server=(localdb)\mssqllocaldb;Database=api_csharp;user=SA;Password=Azxs1230");
        }
    }
    [DisplayColumnAttribute("id", "clientId", true)]
    public class Contact
    {
        [KeyAttribute]
        public readonly Guid id;
        public readonly Guid clientId;
        [PhoneAttribute(ErrorMessage = "Invalid telephone number")]
        public string telephone;
        [PhoneAttribute(ErrorMessage = "Invalid cellphone number")]
        public string cellphone ;
        public string contactName ;
        [EmailAddressAttribute(ErrorMessage = "Invalid Email")]
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
