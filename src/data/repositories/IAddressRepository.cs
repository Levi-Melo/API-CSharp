using System;
using entities;

public interface IAddressRepository {
  Address findById(Guid id);
  Address[] findAll();
  Address[] findByClient(Guid clientId);
  Address insert(Address address);
  Address update(Guid id, Address address);
  Address delete(Guid id);
}