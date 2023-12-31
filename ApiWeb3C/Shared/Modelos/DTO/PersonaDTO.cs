﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiWeb3C.Shared.Modelos.DTO
{
    public class PersonaDTO
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? PaisOrg { get; set; }
        public string? Longitud { get; set; }
        public string? Ubicacion { get; set; }
        public string? NVueltas { get; set; }
        public string? RVueltas { get; set; }

        public int ClasificacionId { get; set; }
        public Clasificacion? Clasificacion { get; set; }
        public int PilotoId { get; set; }
        public Piloto? Piloto { get; set; }

    }
}
