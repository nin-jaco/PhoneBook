using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CIB.PhoneBook.Services.WebApi.Models
{
    public class Contact
    {
        [Column(Order = 1), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Mobile { get; set; }
        public string WorkTelephone { get; set; }
        [Required]
        public System.DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
