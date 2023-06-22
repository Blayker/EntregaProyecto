﻿using System.ComponentModel.DataAnnotations;

namespace ProyectoFinalAPI.Models.Dto
{
    public class EmpleadooDto
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string? Nombre { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
    }
}
