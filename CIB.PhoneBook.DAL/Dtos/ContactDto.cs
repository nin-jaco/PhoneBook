using System;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using CIB.PhoneBook.DAL.Dtos.Infrastructure;
using CIB.PhoneBook.DAL.Model;

namespace CIB.PhoneBook.DAL.Dtos
{
    [DataContract]
    public class ContactDto
    {
        ////BCC/ BEGIN CUSTOM CODE SECTION 
        ////ECC/ END CUSTOM CODE SECTION 
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Mobile { get; set; }
        [DataMember]
        public string WorkTelephone { get; set; }
        [DataMember]
        public DateTime DateCreated { get; set; }
        [DataMember]
        public DateTime? DateModified { get; set; }
    }

    public class ContactDtoMapper : MapperBase<Contact, ContactDto>
    {
        ////BCC/ BEGIN CUSTOM CODE SECTION 
        ////ECC/ END CUSTOM CODE SECTION 
        public override Expression<Func<Contact, ContactDto>> SelectorExpression
        {
            get
            {
                return ((Expression<Func<Contact, ContactDto>>)(p => new ContactDto()
                {
                    ////BCC/ BEGIN CUSTOM CODE SECTION 
                    ////ECC/ END CUSTOM CODE SECTION 
                    Id = p.Id,
                    FirstName = p.FirstName,
                    LastName = p.LastName,
                    Mobile = p.Mobile,
                    WorkTelephone = p.WorkTelephone,
                    DateCreated = p.DateCreated,
                    DateModified = p.DateModified
                }));
            }
        }

        public override void MapToModel(ContactDto dto, Contact model)
        {
            ////BCC/ BEGIN CUSTOM CODE SECTION 
            ////ECC/ END CUSTOM CODE SECTION 
            model.Id = dto.Id;
            model.FirstName = dto.FirstName;
            model.LastName = dto.LastName;
            model.Mobile = dto.Mobile;
            model.WorkTelephone = dto.WorkTelephone;
            model.DateCreated = dto.DateCreated;
            model.DateModified = dto.DateModified;
        }

        public Contact MapToModel(ContactDto dto)
        {
            return new Contact
            {
                Id = dto.Id,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Mobile = dto.Mobile,
                WorkTelephone = dto.WorkTelephone,
                DateCreated = dto.DateCreated,
                DateModified = dto.DateModified
            };
        }

        public ContactDto MapToDto(Contact model)
        {
            return new ContactDto
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Mobile = model.Mobile,
                WorkTelephone = model.WorkTelephone,
                DateCreated = model.DateCreated,
                DateModified = model.DateModified
            };
        }
    }
}
