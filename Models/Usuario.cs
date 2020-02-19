using System;
using System.ComponentModel.DataAnnotations;


namespace aplicacion1.Models
{
    public class Usuario
    {   [Required(ErrorMessage="Ingrese Nombre .")]
        [MaxLength(50,ErrorMessage="Maximo de 50 caracteres")]
        public string Nombre {get;set;}

        [Required(ErrorMessage="Ingrese Apellido")]
        [MaxLength(50,ErrorMessage="Maximo de 50 caracteres")]
        public string Apellido {get;set;}

        [Required(ErrorMessage="Ingrese Email")]
        [EmailAddress(ErrorMessage="Ingrese eamil valido")]
        public string Email {get;set;}
        [Required(ErrorMessage="Ingrese Edad")]
        [Range(18,120,ErrorMessage="Fuera del rango de edad")]
        public int Edad {get;set;}
    }
}