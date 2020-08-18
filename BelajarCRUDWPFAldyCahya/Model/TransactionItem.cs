using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelajarCRUDWPFAldyCahya.Model
{
    [Table("TransactionItem")]
    class TransactionItem
    {
        [Key]
        public string Id { set; get; }
        public int Quantity { set; get; }
        
        public string Transaction_Id { set; get; } //foreign key
        public Transaction Transaction { set; get; } //declare transaction object for many relation
        
        public int Item_Id { set; get; } //foreign key
        public Item Item { set; get; } // declare item object

        
    }
}
