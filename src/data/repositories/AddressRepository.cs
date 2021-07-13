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
        public Address update(Guid id, Address data){
            var db = new AddressesContext();

            var AddressOldData = findById(id);
            //colocar na camada exterior:

            // var newStreet = street == null ? AddressOldData.street : street; 
            // var newNumber = number == -1 ? AddressOldData.number : number; 
            // var newDistrict = district == null ? AddressOldData.district : district; 
            // var newCity = city == null ? AddressOldData.city : city; 
            // var newState = state == null ? AddressOldData.state : state; 
            // var newCep = cep == null ? AddressOldData.cep : cep; 

            // Address AddressNewData = new Address(AddressOldData.clientId, newStreet, newNumber,
            // newDistrict, newCity, newState, newCep, AddressOldData.id, AddressOldData.createdAt);

            db.Update<Address>(data);
            db.SaveChanges();  

            return data;
        }

        public Address delete(Guid id){
            var Address = findById(id);
            if(!(Address == null)){
            var db = new AddressesContext();
                db.Remove<Address>(Address);
                db.SaveChanges(); 
            }
            return Address;
        }
    }
}
