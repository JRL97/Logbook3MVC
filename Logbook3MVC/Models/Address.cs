using System.ComponentModel.DataAnnotations;

namespace Logbook3MVC.Models
{
    public class Address
    {
        public int Id { get; set; }

        [Required, StringLength(20)]
        public string HouseNumber { get; set; } = String.Empty;

        [Required, StringLength(10)]
        public string PostCode { get; set; } = String.Empty;
    }
}
