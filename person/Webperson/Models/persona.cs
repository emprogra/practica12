using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Webperson.Models
{
    public class persona
    {
        [Key]
        public int Code { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Direccion { get; set; }
    }
}