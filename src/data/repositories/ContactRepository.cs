using entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace repository
{
    public class ContactRepository : IContactRepository
    {
        public Contact findById(Guid id){
            var db = new ContactsContext();
            return db.Contacts.Single(contact => contact.id == id);
        }

        public List<Contact> findAll(){
            var db = new ContactsContext();
            return db.Contacts.ToList();
        }
            public List<Contact> findByClient(Guid clientId){
            var db = new ContactsContext();
            return db.Contacts.Where(Contact => Contact.clientId == clientId).ToList();
            
        }
        public Contact insert(Contact Contact){
            var db = new ContactsContext();
            db.Add<Contact>(Contact);
            db.SaveChanges(); 
            return Contact;
        }
        public Contact update( Contact data){
            var db = new ContactsContext();
            db.Update<Contact>(data);
            db.SaveChanges();  
            return data;
        }

        public bool delete(Guid id){
            var contact = findById(id);
            if(contact == null){
                return false;
            }
            var db = new ContactsContext();
                db.Remove<Contact>(contact);
                db.SaveChanges(); 
            contact = findById(id);
            if(contact != null){
                return false;
            }
            return true;
        }
    }
}
