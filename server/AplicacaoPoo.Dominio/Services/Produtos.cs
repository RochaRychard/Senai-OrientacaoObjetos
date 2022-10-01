using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoPoo.Dominio.Services
{
    public class Produtos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal ValorUnitario { get; set; }
    }

    public class ProdutoService
    {
        public List<Produtos> ListagemProdutosFake()
        {
            var lista = new List<Produtos>();

            lista.Add(new Produtos() 
            {
                Id = 00534201,
                Nome = "Molinete",
                ValorUnitario = 10m
            });
            lista.Add(new Produtos()
            {
                Id = 1,
                Nome = "Vara 22lb",
                ValorUnitario = 10m
            });
            lista.Add(new Produtos()
            {
                Id = 00534201,
                Nome = "Carretilha",
                ValorUnitario = 10m
            });
            lista.Add(new Produtos()
            {
                Id = 00534201,
                Nome = "Linha 0.60",
                ValorUnitario = 10m
            });
            lista.Add(new Produtos()
            {
                Id = 00534201,
                Nome = "Frogger",
                ValorUnitario = 10m
            });
            lista.Add(new Produtos()
            {
                Id = 87594201,
                Nome = "Distorcedor",
                ValorUnitario = 10m
            });
            lista.Add(new Produtos()
            {
                Id = 00534201,
                Nome = "Anzol 2/0",
                ValorUnitario = 10m
            });
            lista.Add(new Produtos()
            {
                Id = 87594201,
                Nome = "Boia ",
                ValorUnitario = 10m
            });
            lista.Add(new Produtos()
            {
                Id = 56534209,
                Nome = "Chumbo",
                ValorUnitario = 10m
            });
            lista.Add(new Produtos()
            {
                Id = 04534203,
                Nome = "Repelente",
                ValorUnitario = 10m
            });
            return lista;
        }
    }
}
