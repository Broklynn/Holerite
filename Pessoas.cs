using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estudos_Forms;

namespace Estudos_Forms
{
    public class Pessoas
    {

        public class Pessoa
        {
            public int ID { get; set; }
            public string Nome { get; set; }
            public double Salario { get; set; }
            public double ValeTransporte { get; set; }
            public double ValeAlimentacao { get; set; }
            public double PlanoSaude { get; set; }
        }
        public List<Pessoa> pessoas { get; private set; } = new List<Pessoa>
        {
            new Pessoa {ID = 1, Nome = "Gabriel", Salario = 5000.50, ValeTransporte = 10.00 },
            new Pessoa {ID = 2, Nome = "Jackeline", Salario = 7000.50, ValeTransporte = 30.00, ValeAlimentacao = 40.00 },
            new Pessoa {ID = 3, Nome = "Caio", Salario = 6000.50 , ValeTransporte = 15.00, ValeAlimentacao = 20.00},
            new Pessoa {ID = 4, Nome = "Cecy", Salario = 4000.50, ValeTransporte = 10.00, ValeAlimentacao = 10.00 },
            new Pessoa {ID = 5, Nome = "Andre", Salario = 10000.50, ValeTransporte = 0.00, ValeAlimentacao = 50.00 },
            new Pessoa {ID = 6, Nome = "Sueli", Salario = 8000.50, ValeTransporte = 40.00 , ValeAlimentacao = 60.00}
        };
        
    }
}
