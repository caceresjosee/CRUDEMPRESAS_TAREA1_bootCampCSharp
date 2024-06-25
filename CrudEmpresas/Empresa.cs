using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudEmpresas
{
    internal class Empresa
    {
        private string ruc;
        private string razonSocial;
        private string direccionFiscal;

        public Empresa(string ruc, string razonSocial, string direccionFiscal)
        {
            this.Ruc = ruc;
            this.RazonSocial = razonSocial;
            this.DireccionFiscal = direccionFiscal;
        }

        public string Ruc { get => ruc; set => ruc = value; }
        public string RazonSocial { get => razonSocial; set => razonSocial = value; }
        public string DireccionFiscal { get => direccionFiscal; set => direccionFiscal = value; }


        public void Mostrar()
        {
            Console.WriteLine($"Ruc : {this.ruc}");
            Console.WriteLine($"Razon Social : {this.razonSocial}");
            Console.WriteLine($"Direccion Fiscal : {this.direccionFiscal}");
        }
    }
}
