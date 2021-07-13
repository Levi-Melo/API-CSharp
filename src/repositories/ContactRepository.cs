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
            var Contact = db.Find<Contact>(id);
            return Contact;
        }

        public List<Contact> findAll(){
            var db = new ContactsContext();
            return new List<Contact>(db.Contacts) ;
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

        public Contact delete(Contact data){
            var db = new ContactsContext();
                db.Remove<Contact>(data);
                db.SaveChanges(); 
            return data;
        }
    }
}
