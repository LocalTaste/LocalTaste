using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocalTaste.Domain.POCO
{
    [Table("Reviews")]
    public class Review
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Message { get; set; }

        [Required]
        public int StarRating { get; set; }

        [Required]
        public int RestaurantId { get; set; }
        
        [Required]
        public int UserId { get; set; }

        public virtual User User { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}
