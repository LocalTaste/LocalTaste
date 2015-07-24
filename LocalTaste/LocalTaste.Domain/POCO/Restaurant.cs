using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocalTaste.Domain.POCO
{
    [Table("Restaurants")]
    public class Restaurant
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public Address Address { get; set; }

        [Required]
        public string PhoneNumber { get; set; }
        
        public string WebsiteUrl { get; set; }

        public string OpenTime { get; set; }

        public string CloseTime { get; set; }

        public int PriceRating { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }
    }
}
