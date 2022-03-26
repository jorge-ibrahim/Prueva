﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Localidad
{
    public class LocalidadDto
    {
        public long? Id { get; set; }
        public long? ProvinciaId { get; set; }
        public string Provincia { get; set; }
        public string Descripcion { get; set; }
        public bool EstaEliminado { get; set; }
    }
}
