using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SOMSBlazorApp.Shared
{
    [Table("Window", Schema = "dbo")]
    public class Window
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string WindowName { get; set; }
        [Required]
        public int QuantityOfElement { get; set; }
        public Order? Order { get; set; }
        public int OrderId { get; set; }
    }
}
