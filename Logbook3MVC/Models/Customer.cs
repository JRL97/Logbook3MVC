using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Logbook3MVC.Models
{
    public class Customer
    {
        public int Id { get; set; }

        
        public int AddressID { get; set; }

        [Required, StringLength(20)]
        public string Name { get; set; } = String.Empty;

        [Required, StringLength(20), DataType(DataType.EmailAddress)]
        public string Email { get; set; } = String.Empty;

        [StringLength(20), DataType(DataType.PhoneNumber)]
        public string? PhoneNumber { get; set; } = null;

        // Navigation Properties

        public Address? Address { get; set; } 
    }
}
