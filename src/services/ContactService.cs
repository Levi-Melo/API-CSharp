using entities;
using System;
using System.Collections.Generic;
namespace repository
{
    public class ContactService : IContactService
    {
            public Contact validatePost(Guid clientId, string telephone,string cellphone, string contactName ,string email){
            var db = new ContactsContext();
            Contact Contact = new Contact(clientId, telephone, cellphone, contactName, email);
            var ContactExists = db.Find<Contact>(Contact);
            if(ContactExists == null){
            ContactRepository repo = new ContactRepository();
            //validação de dados aqui
            return repo.insert(Contact);
            }
            return ContactExists;
        }
        public Contact validateDelete(Guid id){
            ContactRepository repo = new ContactRepository();
            var db = new ContactsContext();
            var ContactExists =  repo.findById(id);
            if(!(ContactExists == null)){
            repo.delete(ContactExists);
            return ContactExists;
            }
            return ContactExists;
        }
        public Contact constructConcactToUpdate(Guid id,string telephone = null,string cellphone = null, string contactName = null,string email = null){

            ContactRepository repo = new ContactRepository();
            var db = new ContactsContext();

            var ContactExists =  repo.findById(id);
            if(!(ContactExists == null)){
           
            //validadar data aqui
            var newTelephone = telephone == null ? ContactExists.telephone : telephone; 
            var newCellphone = cellphone == null ? ContactExists.cellphone : cellphone; 
            var newContactName = contactName == null ? ContactExists.contactName : contactName; 
            var newEmail = email == null ? ContactExists.email : email; 

            Contact ContactNewData = new Contact(ContactExists.clientId, newTelephone, newCellphone,
            newContactName, newEmail, ContactExists.id, ContactExists.createdAt);

            repo.update(ContactNewData);

            return ContactNewData;
            }
            return ContactExists;
        }
    }
}
