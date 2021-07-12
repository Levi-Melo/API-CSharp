using System;
using entities;

public interface IClientRepository {
  Client findById(Guid id);
  Client[] findAll();
  Client insert(Client client);
  Client update(Guid id, Client client);
  Client delete(Guid id);
}