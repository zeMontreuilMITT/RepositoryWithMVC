using System.ComponentModel.DataAnnotations;

namespace RepositoryWithMVC.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }

        [Required]
        [Display(Name = "Is Active")]
        public bool IsActive { get; set; } = true; 
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
    }
}
