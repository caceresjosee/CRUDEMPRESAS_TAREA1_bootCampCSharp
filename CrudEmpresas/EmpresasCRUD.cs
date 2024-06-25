using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudEmpresas
{
    internal class EmpresasCRUD
    {
        private List<Empresa> listaEmpresas = new List<Empresa>();
        private MensajeUI mensaje =new MensajeUI(50);

        public EmpresasCRUD() 
        {
            Empresa empresamuestra1 = new Empresa("102222222","Konecta SAC"," av.JavierPrado 1550");
            listaEmpresas.Add(empresamuestra1);
        }

        public void MostrarEmpresas()
        {
            this.mensaje.mostrarTitulo("LISTA DE EMPRESAS");
            foreach (var emp in listaEmpresas)
            {
                Console.WriteLine(new string('*', 50));
                emp.Mostrar();
            }
        }
        public void RegistrarEmpresa()
        {
            this.mensaje.mostrarTitulo("REGISTRAR EMPRESA");
            Console.WriteLine("RUC : ");
            string ruc = Console.ReadLine();
            Console.WriteLine("RAZON SOCIAL : ");
            string razon = Console.ReadLine();
            Console.WriteLine("DIRECCION FISCAL : ");
            string direccion = Console.ReadLine();
            Empresa nuevaEmpresa = new Empresa(ruc,razon,direccion);
            listaEmpresas.Add(nuevaEmpresa);
            this.mensaje.mostrarMensaje("EMPRESA REGISTRADO CON EXITO !!");

        }


        private Empresa BuscarEmpresa(string opcion)
        {
            Console.WriteLine($" {opcion} EMPRESA");
            Console.WriteLine($"INGRESE EL RUC DE LA EMPRESA {opcion} : ");
            string ruc = Console.ReadLine();

            Empresa empresa = listaEmpresas.Find(a => a.Ruc.Equals(ruc, StringComparison.OrdinalIgnoreCase));
            return empresa;
        }

        public void ActualizarEmpresa()
        {
            Empresa empresa = this.BuscarEmpresa("ACTUALIZAR");

            if (empresa != null)
            {
                Console.WriteLine("NUEVO RUC : ");
                string nuevoRUC = Console.ReadLine();
                Console.WriteLine("NUEVA RAZON SOCIAL : ");
                string nuevaRazon = Console.ReadLine();
                Console.WriteLine("NUEVA DIRECCION : ");
                string nuevaDireccion = Console.ReadLine();

                empresa.Ruc = nuevoRUC;
                empresa.RazonSocial = nuevaRazon;
                empresa.DireccionFiscal = nuevaDireccion;
                  


                this.mensaje.mostrarMensaje("EMPRESA ACTUALIZADA CON EXITO !!");
            }
            else
            {
                this.mensaje.mostrarMensaje("EMPRESA NO ENCONTRADA");
            }
        }


        public void EliminarEmpresa()
        {
            Empresa empresa = this.BuscarEmpresa("ELIMINAR");

            if (empresa != null)
            {
                listaEmpresas.Remove(empresa);
                this.mensaje.mostrarMensaje("EMPRESA ELIMINADA CON EXITO!!");
            }
            else
            {
                this.mensaje.mostrarMensaje("NO SE ENCONTRO LA EMPRESA..");
            }
        }





    }
}
