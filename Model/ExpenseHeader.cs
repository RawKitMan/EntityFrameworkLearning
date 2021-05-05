using System;
using System.ComponentModel.DataAnnotations;
namespace Model
{
    public class ExpenseHeader
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="{0} is required")]
        [MaxLength(100, ErrorMessage ="{0} cannot be more than 100 characters")]
        [MinLength(10)]
        public string Description { get; set; }
        public DateTime? ExpenseDate { get; set; }
    }
}
