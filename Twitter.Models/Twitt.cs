using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter.Models
{
    public class Twitt
    {
        [Key]
        public int TwittId { get; set; }

        [Required]
        [MaxLength(200)]
        public string Text { get; set; }
    }
}
