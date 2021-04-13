using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Trabajo1.Models
{
    public enum Departamentos
    {
        Santa_Cruz,
        Cochabamba,
        La_Paz,
        Oruro,
        Tarija,
    }
    public class Person
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public Departamentos place { get; set; }
        [EmailAddress(ErrorMessage = "Ingrese correo valido")]
        public string Email { get; set; }

    }
}