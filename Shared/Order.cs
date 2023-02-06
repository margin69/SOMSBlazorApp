using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SOMSBlazorApp.Shared
{
    [Table("Order", Schema = "dbo")]
    public class Order
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string OrderName { get; set; }
        [Required]
        public string State { get; set; }
        public Window? Window { get; set; }
        public int WindowId { get; set; }
    }
}
