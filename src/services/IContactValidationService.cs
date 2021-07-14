using System;
using entities;
interface IContactValidationService{
    Contact validatePost(Guid clientId, string telephone,string cellphone, string contactName ,string email);
    Contact validateDelete(Guid id);
    Contact constructConcactToUpdate(Guid id,string telephone = null,string cellphone = null, string contactName = null,string email = null);
}