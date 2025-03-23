using System.ComponentModel.DataAnnotations;

namespace Auto_Mapper_Practice
{
    public class AddressOuter
    {
        public int AddressId { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public int UserId { get; set; } // Foreign Key
        public User User { get; set; }
    }
}
