using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
