using System;
using entities;
interface IAddressValidationService{
    Address validatePost(Guid clientId, string street,int number, string district ,string city , string state , string cep );
    Address validateDelete(Guid id);
    Address constructAddressToUpdate(Guid id,string street = null,int number = -1,
     string district = null,string city = null, string state = null, string cep = null);

}            
