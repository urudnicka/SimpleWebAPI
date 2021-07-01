using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiProject.Models
{
    public class TestObj
    {
        [Required(ErrorMessage = "Number field is required")]
        [Range(0,10, ErrorMessage = "Number must be between 0 and 10")]
        public int? Number { get; set; }

        [Required(ErrorMessage = "Text field is required")]
        [RegularExpression("[abcd]+", ErrorMessage = "Text may contain only letters [a,b,c,d]")]
        public string Text { get; set; }
    }
}
