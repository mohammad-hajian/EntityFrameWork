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
    class FullName
    {
        public FullName(string lastName)
        {
            LastName = lastName;
        }
        public FullName(string firstName,string lastName)
        {
            LastName = lastName;
            FirstName = firstName;
        }

        [Column("نام")]
        public string FirstName { get; set; }
        [Required]
        [Column("فامیل")]
        public string LastName { get; set; }
    }
}
