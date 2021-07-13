using System;
using System.Collections.Generic;
using entities;

public interface IContactRepository {
  Contact findById(Guid id);
  List<Contact> findAll();
  List<Contact> findByClient(Guid clientId);
  Contact insert(Contact contact);
  Contact update(Guid id, Contact contact);
  Contact delete(Guid id);
}