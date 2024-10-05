﻿using System.ComponentModel.DataAnnotations;

namespace BdaUai.Models.Entidades
{
    public class Autor
    {

        public Autor() { }


        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Nombre { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/mm/yyyy}")]
        public DateTime FechaNacimiento { get; set; }
    }
}
