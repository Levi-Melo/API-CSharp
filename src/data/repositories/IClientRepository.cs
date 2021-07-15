using System;
using System.Collections.Generic;
using entities;

public interface IClientRepository {
  Client findById(Guid id);
  List<Client> findAll();
  Client insert(Client client);
  Client update(Client client);
  bool delete(Guid id);
}