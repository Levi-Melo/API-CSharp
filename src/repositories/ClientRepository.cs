using entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace repository
{
    public class ClientRepository : IClientRepository
    {
        public Client findById(Guid id){
            var db = new ClientsContext();
            return db.Clients.Single(client => client.id == id);
        }

        public List<Client> findAll(){
            var db = new ClientsContext();
            return db.Clients.ToList();
        }
        public Client insert(Client data){
            var db = new ClientsContext();
            db.Add<Client>(data);
            db.SaveChanges(); 
            return data;
        }
        public Client update(Client data){
            var db = new ClientsContext();
            db.Update<Client>(data);
            db.SaveChanges(); 
            return data;
        }

        public void delete(Client client){
            var db = new ClientsContext();
                db.Remove<Client>(client);
                db.SaveChanges(); 
            }
        }
}

