using entities;
using System;
using System.Collections.Generic;
namespace repository
{
    public class ClientValidationService : IClientValidationService
    {
            public Client validatePost(string name, string cnpj ){
            var db = new ClientsContext();
            var clientExists = db.Find<Client>(cnpj);
            if(clientExists == null){
            Client client = new Client(name, cnpj, null, null);
            ClientRepository repo = new ClientRepository();
            return repo.insert(client);
            }
            return clientExists;
        }
        public Client validateDelete(Guid id){
            ClientRepository repo = new ClientRepository();
            var db = new ClientsContext();
            var clientExists =  repo.findById(id);
            if(!(clientExists == null)){
            repo.delete(clientExists);
            return clientExists;
            }
            return clientExists;
        }
        public Client validateClientToUpdate(Guid id ,string name = null, string cnpj = null){

            ClientRepository repo = new ClientRepository();
            var db = new ClientsContext();
            var clientExists =  repo.findById(id);
            if(!(clientExists == null)){
            var newName = name == null ? clientExists.name : name; 
            var newCnpj = cnpj == null ? clientExists.cnpj : cnpj; 

            Client clientNewData = new Client(newName, newCnpj, null, null, id, clientExists.createdAt);
            repo.update(clientNewData);

            return clientNewData;
            }
            return clientExists;
        }
    }
}
