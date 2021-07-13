using System;
using System.Collections.Generic;
using entities;

public interface IClientRepository {
  Client findById(Guid id);
  List<Client> findAll();
  Client insert(Client client);
  Client update(Guid id,  string name = null, string cnpj = null, List<Address> addresses = null, List<Contact> contacts = null);
  Client delete(Guid id);
}