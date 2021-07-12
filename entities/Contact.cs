#nullable enable
using System;
namespace entities
{
    public class Contact
    {
        private Guid id {get; set;}
        private Guid clientId {get; set;}
        string telephone;
        string cellphone ;
        string contactName ;
        string email;
        DateTime createdAt;
        DateTime updatedAt;
        public Contact(
            Guid id, Guid clientId,string telephone, string cellphone , string contactName , string email,
            DateTime createdAt = new DateTime(), DateTime updatedAt = new DateTime()){
            this.id = id;
            this.createdAt = createdAt;
            this.updatedAt = updatedAt;
            this.clientId = clientId;
            this.telephone = telephone;
            this.cellphone= cellphone;
            this.contactName = contactName;
            this.email = email;
        }
    }
}
