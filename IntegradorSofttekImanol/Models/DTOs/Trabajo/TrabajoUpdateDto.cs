﻿namespace IntegradorSofttekImanol.Models.DTOs.Trabajo
{
    public class TrabajoUpdateDto
    {
        public int codTrabajo { get; set; }
        public DateTime Fecha { get; set; }
        public int CodProyecto { get; set; }
        public int CodServicio { get; set; }
        public int CantHoras { get; set; }
        public decimal valorHora { get; set; }

    }
}