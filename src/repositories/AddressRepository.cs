using entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace repository
{
    public class AddressRepository : IAddressRepository
    {
        public Address findById(Guid id){
            var db = new AddressesContext();
            var Address = db.Find<Address>(id);
            return Address;
        }

        public List<Address> findAll(){
            var db = new AddressesContext();
            return new List<Address>(db.Addresses) ;
        }
            public List<Address> findByClient(Guid clientId){
            var db = new AddressesContext();
            return db.Addresses.Where(address => address.clientId == clientId).ToList();
            
        }
        public Address insert(Address address){
            var db = new AddressesContext();
            db.Add<Address>(address);
            db.SaveChanges(); 
            return address;
        }
        public Address update(Address data){
            var db = new AddressesContext();

            var AddressOldData = findById(data.id);

            db.Update<Address>(data);
            db.SaveChanges();  

            return data;
        }

        public void delete(Address address){
            var db = new AddressesContext();
                db.Remove<Address>(address);
                db.SaveChanges(); 
        }
    }
}
