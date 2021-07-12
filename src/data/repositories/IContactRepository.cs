using System;
using entities;

public interface IContactRepository {
  Contact findById(Guid id);
  Contact[] findAll();
  Contact[] findByClient(Guid clientId);
  Contact insert(Contact contact);
  Contact update(Guid id, Contact contact);
  Contact delete(Guid id);
}