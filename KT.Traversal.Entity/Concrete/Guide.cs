using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace KT.Traversal.Entity.Concrete
{
    public class Guide
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string TwitterURL { get; set; }
        public string InstagramURL { get; set; }
        public bool Status { get; set; }
    }
}
