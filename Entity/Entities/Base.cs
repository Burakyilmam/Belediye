using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class Base
    {
        [Key]
        public int Id { get; set; }
        public bool Statu { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
