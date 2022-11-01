﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estudiante : Persona
    {
        public string curso { get; set; }
        public string Grado { get; set; }
        public string PeriodoEstudio { get; set; }
        public double PromPonderado { get; set; }
        public string EscuelaRegistrada { get; set; }
        public bool Estado()
        {
            return false;
        }
        public override string ToString()
        {
            return $"{Nombres};{Apellidos};{Sexo};{Id}" +
                $";{curso};{Grado};{PeriodoEstudio};{PromPonderado};{EscuelaRegistrada}";
        }
    }
}
