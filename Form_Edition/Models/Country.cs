using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_Edition.Models
{
    [Table("keshvarHa")]
    class Country
    {
        public Country()
        {
            ODate = DateTime.Now;
        }
        public void setDateTime(DateTime oDate2)
        {
            ODate = oDate2;
        }
        //اگر خواستیم دو تا پرایمری کی داشته باشیم باید نام اوردر تعریف کنیم
        [Column("id keshvar")]
        [Key]
        [Required]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [MaxLength(100)]
        [Column("name keshvar")]
        [Required]
        public string Name { get; set; }

        [Column("زمان")]
        [Required]
        public DateTime ODate { get; private set; }

        public string DisplayName
        {
            get
            {
                return string.Format($"{ID} - {Name} - {ODate}");
            }

        }
    }
}
