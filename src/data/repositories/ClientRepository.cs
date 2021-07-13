using entities;
using System;
using System.Collections.Generic;
namespace repository
{
    public class ClientRepository : IClientRepository
    {
        public Client findById(Guid id){
            var db = new ClientsContext();
            var client = db.Find<Client>(id);
            return client;
        }

        public List<Client> findAll(){
            var db = new ClientsContext();
            return new List<Client>(db.Clients) ;
        }
        public Client insert(Client data){
            var db = new ClientsContext();
            db.Add<Client>(data);
            db.SaveChanges(); 
            return data;
        }
        public Client update(Guid id, string name = null, string cnpj = null, 
        List<Address> addresses = null, List<Contact> contacts = null){
            var db = new ClientsContext();
            
            var clientOldData = findById(id);
            Client clientNewData = new Client(name, cnpj, addresses, contacts,id, clientOldData.createdAt);

            db.Update<Client>(clientNewData);
            db.SaveChanges(); 
            return clientNewData;
        }

        public Client delete(Guid id){
            var client = findById(id);
            if(!(client == null)){
            var db = new ClientsContext();
                db.Remove<Client>(client);
                db.SaveChanges(); 
            }
            return client;
        }
    }
}
