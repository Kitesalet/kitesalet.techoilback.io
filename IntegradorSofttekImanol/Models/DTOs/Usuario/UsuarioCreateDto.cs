﻿namespace IntegradorSofttekImanol.Models.DTOs.Usuario
{
    public class UsuarioCreateDto
    {
        public int CodUsuario { get; set; }
        public string Nombre { get; set; }
        public int Dni { get; set; }
        public int Tipo { get; set; }
        public string Contrasena { get; set; }

    }
}
