#nullable enable
using System;
namespace entities
{
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
