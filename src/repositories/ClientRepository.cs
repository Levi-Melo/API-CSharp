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
        public Client update(Client client){
            var db = new ClientsContext();
            db.Update<Client>(client);
            db.SaveChanges(); 
            return client;
        }

        public void delete(Client client){
            var db = new ClientsContext();
                db.Remove<Client>(client);
                db.SaveChanges(); 
            }
        }
}

