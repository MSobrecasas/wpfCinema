using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase.ListasAuxiliares
{
    public class ListaCliente
    {
        //public  ListCliente = new List<Cliente>();

        public List<Cliente> cargar_lista() {
            List<Cliente> ListCliente = new List<Cliente>();

            ListCliente.Clear();
            Cliente oCliente = new Cliente();
            oCliente.Cli_Nombre = "Samuel";
            oCliente.Cli_Apellido = "de Luque Batuecas";
            oCliente.Cli_DNI = 111;
            oCliente.Cli_Email = "mail";
            oCliente.Cli_Telefono = "1544445555";
            ListCliente.Add(oCliente);

            Cliente oCliente1 = new Cliente();
            oCliente.Cli_Nombre = "Alejandro";
            oCliente.Cli_Apellido = "Bravo Yañez";
            oCliente.Cli_DNI = 111;
            oCliente.Cli_Email = "mail";
            oCliente.Cli_Telefono = "1544445555";
            ListCliente.Add(oCliente1);

            Cliente oCliente2 = new Cliente();
            oCliente.Cli_Nombre = "Guillermo ";
            oCliente.Cli_Apellido = "Díaz Íbañez";
            oCliente.Cli_DNI = 111;
            oCliente.Cli_Email = "mail";
            oCliente.Cli_Telefono = "1544445555";
            ListCliente.Add(oCliente2);


            Cliente oCliente3 = new Cliente();
            oCliente.Cli_Nombre = "Raúl";
            oCliente.Cli_Apellido = "Álvarez Genes";
            oCliente.Cli_DNI = 111;
            oCliente.Cli_Email = "mail";
            oCliente.Cli_Telefono = "1544445555";
            ListCliente.Add(oCliente3);

            return ListCliente;

        }
    }
}
