﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FARMACIA.Logica
{
    internal class Conexion
    {
        public static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ToString();
    }
}
