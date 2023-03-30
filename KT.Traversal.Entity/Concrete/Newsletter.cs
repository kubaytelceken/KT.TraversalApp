using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace KT.Traversal.Entity.Concrete
{
    public class Newsletter
    {
        [Key]
        public int Id { get; set; }
        public string Mail { get; set; }
    
    }
}
