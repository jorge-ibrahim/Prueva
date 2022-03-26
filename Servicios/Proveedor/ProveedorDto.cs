﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Proveedor
{
    public class ProveedorDto
    {
        public long Id { get; set; }
        public string RazonSocial { get; set; }
        public string Cuil { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public bool EstaEliminado { get; set; }
    }

}
