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
    [ComplexType]
    class Address
    {
        public Address(string country)
        {
            Country = country;
        }
        [Required]
        [Column("نام کشور")]
        public string Country { get; set; }
        [Column("نام شهر")]
        public string City { get; set; }
        [Column("شماره پلاک")]
        public int pelak { get; set; }
    }
}
