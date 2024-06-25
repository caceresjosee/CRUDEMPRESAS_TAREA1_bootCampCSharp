﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudEmpresas
{
    internal class EmpresaUI
    {
        const int ANCHO = 50;
        private EmpresasCRUD crud;
        private MensajeUI mensajeUI = new MensajeUI(100);

        public EmpresaUI()
        {
            crud = new EmpresasCRUD();
        }




        public void MostrarMenuPrincipal()
        {
            int opcion = 0;
            while (opcion != 5)
            {
                Console.Clear();
                this.mensajeUI.mostrarTitulo("CRUD DE EMPRESAS");
                Console.WriteLine(@"
                 [1] REGISTRAR EMPRESA
                 [2] MOSTRAR EMPRESA
                 [3] ACTUALIZAR EMPRESA
                 [4] ELIMINAR EMPRESA
                 [5] SALIR
                ");
                this.mensajeUI.mostrarTitulo("INGRESE UNA OPCION DEL MENU : ");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        crud.RegistrarEmpresa();
                        break;
                    case 2:
                        crud.MostrarEmpresas();
                        Console.WriteLine("PRESIONE ENTER PARA CONTINUAR");
                        Console.ReadKey();
                        break;
                    case 3:
                        crud.ActualizarEmpresa();
                        break;
                    case 4:
                        crud.EliminarEmpresa();
                        break;
                    case 5:
                        Console.WriteLine("SALIENDO DEL SISTEMA ...");
                        break;
                    default:
                        this.mensajeUI.mostrarMensaje("OPCION INVALIDA!!");
                        break;
                }
            }
        }


    }
}
