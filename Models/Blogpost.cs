using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ANOOSHEH_Library.Models
{
    public class Blogpost
    {
        public int Id { get; set; }
        public string Subject { get; set; }

        [Required(ErrorMessage = "System can not accept empty post")]
        [StringLength(100)]
        public string Text { get; set; }
        public string Comment { get; set; }
        public DateTime Posted { get; set; }
    }
}
