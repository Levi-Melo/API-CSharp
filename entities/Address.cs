#nullable enable
using System;

namespace entities
{
    public class Address
    {
        private Guid id {get; set;}
        private Guid clientId {get; set;}
        string street;
        int number;
        string district;
        string city;
        string state;
        string cep;
        DateTime createdAt;
        DateTime updatedAt;
        public Address(
            Guid id, Guid clientId, string street, int number,string district,string city,string state,string cep,
            DateTime createdAt = new DateTime(), DateTime updatedAt = new DateTime()){
            this.street = street;
            this.id = id;
            this.createdAt = createdAt;
            this.updatedAt = updatedAt;
            this.clientId = clientId;
            this.number = number;
            this.district = district;
            this.city = city;
            this.state = state;
            this.cep = cep;
        }
    }
}
