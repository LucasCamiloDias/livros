using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace livros.Controller
{
    internal class Emprestimo
    {
        private decimal valor;
        private decimal frete;
        private string UF;
        public Emprestimo() { }
        public decimal Calcular(string uf, decimal v)
        {
            this.UF = uf;
            this.valor = v;
            this.frete = 0;

            switch (uf)
            {
                case "10%":
                    this.frete = 0.10m;
                    break;
                case "20%":
                    this.frete = 0.20m;
                    break;
                case "30%":
                    this.frete = 0.30m;
                    break;
             
            }
            valor = frete * valor;
            valor = v - valor;
            return valor;

        }
    }
}
