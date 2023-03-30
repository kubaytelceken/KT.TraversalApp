using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace KT.Traversal.Entity.Concrete
{
    public class Feature
    {
        [Key]
        public int Id { get; set; }
        public string PostName { get; set; }
        public string PostDescription { get; set; }
        public string PostImage { get; set; }
        public bool Status { get; set; }
    }
}
