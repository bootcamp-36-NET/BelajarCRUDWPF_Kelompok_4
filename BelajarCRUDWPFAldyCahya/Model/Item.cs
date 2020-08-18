using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelajarCRUDWPFAldyCahya.Model
{
    [Table("items")]
    class Item
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        [MaxLength(4)]
        public string Supplier_Id { get; set; }
        public Supplier Supplier { get; set; }
        public ICollection<TransactionItem> TransactionItems { set; get; }

    }
}
