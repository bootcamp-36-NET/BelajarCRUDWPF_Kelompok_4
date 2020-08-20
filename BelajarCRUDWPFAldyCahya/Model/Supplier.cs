using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelajarCRUDWPFAldyCahya.Model
{
    [Table("suppliers")]
    class Supplier
    {
        [Key]
        [MaxLength(4)]
        public string Id { get; set; }
        [MaxLength(128)]
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        [Column(TypeName = "Date")]
        public DateTime JoinDate { get; set; }
        public int gId { get; set; }
        public ICollection<Item> Items { get; set; }

    }
}
