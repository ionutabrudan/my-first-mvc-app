using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstMvcApp.Models
{
    public class ContactListEntry
    {
        [Key]
        [Required]
    public int Id { get; set; }
        [Display(Name = "ContactType")]
        [Required]
        public ContactType ContactType { get; set; }
       
        [Required]
        [StringLength (100)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Date of birth")]
        [DataType(DataType.Date)]
    public DateTime? DateOfBirth { get; set; }

        [Display(Name = "Phone number")]
        [StringLength(20)]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Display(Name = "Email")]
        [StringLength(20)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
       
}
