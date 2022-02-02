using System;
using static System.Console;
using System.Collections.Generic;

namespace livrocsharp
{
    public class Medico
    {
        public int ID {get; set;}
        public string Nome {get; set;}
        // um médico tem uma coleção de Pacientes <T>
        public List<Paciente> Pacientes {get; set;}
    }

    public class Paciente
    {
        public int ID{get; set;}
        public string NomePaciente {get; set;}
        public string Historico {get; set;} = "nada relatado";
        public string Remedios { get; set;}

        public decimal ValorConsulta {get; set;} = 0;
        public bool Internado {get; set;}

    }
}