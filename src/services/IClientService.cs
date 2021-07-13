using System;
using entities;
interface IClientService{
    Client validatePost(string name, string cnpj);
    Client validateDelete(Guid id);
    Client validateClientToUpdate(Guid id ,string name = null, string cnpj = null);
}