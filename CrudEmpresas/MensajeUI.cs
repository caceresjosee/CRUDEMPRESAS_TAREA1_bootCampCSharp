using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudEmpresas
{
    internal class MensajeUI
    {
        private int ancho = 50;
        public MensajeUI(int ancho)
        {
            this.ancho = ancho;

        }
        public void mostrarTitulo(string titulo)
        {
            Console.WriteLine(new string('=', ancho));
            Console.WriteLine(new string(' ', 15) + titulo);
            Console.WriteLine(new string('=', ancho));

        }
        public void mostrarMensaje(string mensaje)
        {
            Console.Clear();
            Console.WriteLine(new string('*', ancho));
            Console.WriteLine(new string(' ', 15) + mensaje);
            Console.WriteLine(new string('*', ancho));
            System.Threading.Thread.Sleep(1000);
        }

    }
}
