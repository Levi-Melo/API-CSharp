using System;
using System.Collections.Generic;
using entities;

public interface IAddressRepository {
  Address findById(Guid id);
  List<Address> findAll();
  List<Address> findByClient(Guid clientId);
  Address insert(Address address);
  Address update(Guid id, Address address);
  Address delete(Guid id);
}