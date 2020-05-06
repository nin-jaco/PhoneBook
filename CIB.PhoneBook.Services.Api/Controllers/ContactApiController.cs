using CIB.PhoneBook.Services.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CIB.PhoneBook.Services.Api.Controllers
{
   [RoutePrefix("Api/Contact")]  
   public class ContactApiController : ApiController  
   {
       private PhoneBookEntities PhoneBookEntities { get; } = new PhoneBookEntities();

       [HttpGet]  
       [Route("GetAll")]  
       public IQueryable<Contact> GetAll()
       {  
           try  
           {  
               return PhoneBookEntities.Contacts;  
           }  
           catch(Exception)  
           {  
               throw;  
           }  
       }  
 
       [HttpGet]  
       [Route("GetById/{contactId}")]  
       public IHttpActionResult GetById(int contactId)
       {  
           Contact contact;  
           var id = Convert.ToInt32(contactId);  
           try  
           {  
               contact = PhoneBookEntities.Contacts.Find(id);  
               if (contact == null)  
               {  
                   return NotFound();  
               }  
 
           }  
           catch (Exception)  
           {  
               throw;  
           }  
           
           return Ok(contact);  
       }  
 
       [HttpPost]  
       [Route("Insert")]  
       public IHttpActionResult Insert (Contact data)
       {  
            
           if (!ModelState.IsValid)  
           {  
               return BadRequest(ModelState);  
           }  
           try  
           {
               PhoneBookEntities.Contacts.Add(data);
               PhoneBookEntities.SaveChanges();  
           }  
           catch(Exception)  
           {  
               throw;  
           }  
 
           return Ok(data);  
       }  
        
       [HttpPut]  
       [Route("Update")]  
       public IHttpActionResult Update(Contact contact)
       {  
           if (!ModelState.IsValid)  
           {  
               return BadRequest(ModelState);  
           }  
 
           try  
           {  
               var entity = PhoneBookEntities.Contacts.Find(contact.Id);  
               if (entity != null)
               {
                   entity.LastName = contact.LastName;
                   entity.DateCreated = DateTime.Now;
                   entity.DateModified = DateTime.Now;
                   entity.FirstName = contact.FirstName;
                   entity.Mobile = contact.Mobile;
                   entity.WorkTelephone = contact.WorkTelephone;

               }  
               var i = PhoneBookEntities.SaveChanges();  
 
           }  
            catch(Exception)  
            {  
                throw;  
            }  
            return Ok(contact);  
        }  

        [HttpDelete]  
        [Route("Delete")]  
        public IHttpActionResult Delete(int id)
        {  
            //int empId = Convert.ToInt32(id);  
            Contact contact = PhoneBookEntities.Contacts.Find(id);  
            if (contact == null)  
            {  
                return NotFound();  
            }

            PhoneBookEntities.Contacts.Remove(contact);
            PhoneBookEntities.SaveChanges();  
  
            return Ok(contact);  
        }  
    }  

}
