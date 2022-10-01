using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoPoo.Dominio.services
{
    public class VendedorService
    {
        public const string Nome0 = "SELECT..";
        public const string Nome1 = "Raul Seixas";
        public const string Nome2 = "Cazuza Araujo";
        public const string Nome3 = "Renato Russo";
        public const string Nome4 = "Janis Joplin";
        public const string Nome5 = "Jimi Hendrix";
        public const string Nome6 = "Robert Plant";
        public const string Nome7 = "Jimi Page";
        public const string Nome8 = "Ozzy Osborne";
        public const string Nome9 = "João Gordo";
        public const string Nome10 = "Anrea Doria";

        public List<Vendedor> ListaDEVendedores()
        {
            var listaDEVendedores = new List<Vendedor>();

            listaDEVendedores.Add(new Vendedor() { Nome = "SELECT.." });
            listaDEVendedores.Add(new Vendedor() { Nome = "Raul Seixas" });
            listaDEVendedores.Add(new Vendedor() { Nome = "Andrea Doria"});
            listaDEVendedores.Add(new Vendedor() { Nome = "João Gordo" });
            listaDEVendedores.Add(new Vendedor() { Nome = "Ozzy Osborne" });
            listaDEVendedores.Add(new Vendedor() { Nome = "Renato Russo" });
            listaDEVendedores.Add(new Vendedor() { Nome = "Cazuza Araujo" });
            listaDEVendedores.Add(new Vendedor() { Nome = "Jimi Hendrix" });
            listaDEVendedores.Add(new Vendedor() { Nome = "Jimi Page" });
            listaDEVendedores.Add(new Vendedor() { Nome = "Robert Plant" });
            listaDEVendedores.Add(new Vendedor() { Nome = "Ozzy Osborne" });
            return listaDEVendedores;

        }


    }
}
