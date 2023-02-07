using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SOMSBlazorApp.Shared
{
    [Table("Element", Schema = "dbo")]
    public class Element
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int Width { get; set; }
        [Required]
        public int Height { get; set; }

        public Window? Window { get; set; }
        public int WindowId { get; set; }
    }
}
