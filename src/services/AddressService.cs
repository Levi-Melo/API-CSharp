using entities;
using System;
using System.Collections.Generic;
namespace repository
{
    public class AddressService : IAddressService
    {
            public Address validatePost(Guid clientId, string street,int number, string district ,string city , string state , string cep){
            var db = new AddressesContext();
            Address Address = new Address(clientId, street, number, district, city, state, cep);
            var addressExists = db.Find<Address>(Address);
            if(addressExists == null){
            AddressRepository repo = new AddressRepository();
            //validação de dados aqui
            return repo.insert(Address);
            }
            return addressExists;
        }
        public Address validateDelete(Guid id){
            AddressRepository repo = new AddressRepository();
            var db = new AddressesContext();
            var addressExists =  repo.findById(id);
            if(!(addressExists == null)){
            repo.delete(addressExists);
            return addressExists;
            }
            return addressExists;
        }
        public Address constructAddressToUpdate(Guid id,string street = null,int number = -1, string district = null,string city = null, string state = null, string cep = null){

            AddressRepository repo = new AddressRepository();
            var db = new AddressesContext();

            var addressExists =  repo.findById(id);
            if(!(addressExists == null)){
           
            //validadar data aqui
            var newStreet = street == null ? addressExists.street : street; 
            var newNumber = number == -1 ? addressExists.number : number; 
            var newDistrict = district == null ? addressExists.district : district; 
            var newCity = city == null ? addressExists.city : city; 
            var newState = state == null ? addressExists.state : state; 
            var newCep = cep == null ? addressExists.cep : cep; 

            Address AddressNewData = new Address(addressExists.clientId, newStreet, newNumber,
            newDistrict, newCity, newState, newCep, addressExists.id, addressExists.createdAt);

            repo.update(AddressNewData);

            return AddressNewData;
            }
            return addressExists;
        }
    }
}
