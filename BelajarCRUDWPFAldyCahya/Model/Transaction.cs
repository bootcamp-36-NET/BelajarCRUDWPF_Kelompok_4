using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelajarCRUDWPFAldyCahya.Model
{
    [Table("Transaction")]
    
    class Transaction
    {
        [Key]
        public string Id { set; get; }
        public DateTime OrderDate { set; get; }
        public ICollection<TransactionItem> TransactionItems { set; get; } // declare navigation property for one relation

    }
}
