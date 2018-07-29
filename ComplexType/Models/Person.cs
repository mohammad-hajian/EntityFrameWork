using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ComplexType.Models
{
    [Table("مردم")]
    class Person
    {
        [Required]
        [Key]
        public int ID { get; set; }
        [Required]
        public Address GetAddress { get; set; }
        [Required]
        public FullName GetFullName { get; set; }
        [Column("سایر توضیحات")]
        public string Description { get; set; }
    }
}
