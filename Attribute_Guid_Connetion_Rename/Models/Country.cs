using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Attribute_Guid_Connetion_Rename.Models
{
    [Table("keshvarHa")]
    class Country
    {
        public Country(string name)
        {
            Name = name;
            ID = Guid.NewGuid();
            ID2 = Guid.NewGuid();
        }
        public Country()
        {
            ID = Guid.NewGuid();
            ID2 = Guid.NewGuid();
        }
        //اگر خواستیم دو تا پرایمری کی داشته باشیم باید نام اوردر تعریف کنیم
        [Column("id1 keshvar", Order = 0)]
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid ID { get; set; }

        [Column("id2 keshvar", Order = 1)]
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid ID2 { get; set; }

        [Required]
        [Column("name keshvar")]
        [MaxLength(100)]
        public string Name { get; set; }

        [NotMapped]//دیگر به فیلد جدول تبدیل نمیشود
        public int intA { get; set; }
    }
}

