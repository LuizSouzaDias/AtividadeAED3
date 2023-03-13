using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAvaliativa3
{
    internal class Vendedor
    {
        private string nome;
        private double salario;
        private double totalVendas;

        public Vendedor() { }

        public Vendedor(string nome, double salario, double totalVendas)
        {
            this.nome = nome;
            this.salario = salario;
            this.totalVendas = totalVendas;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getNome()
        {
            return this.nome;
        }

        public void setSalario(double salario)
        {
            this.salario = salario;
        }

        public double getSalario()
        {
            return this.salario;
        }

        public void setTotalVendas(double totalVendas)
        {
            this.totalVendas = totalVendas;
        }

        public double getTotalVendas()
        {
            return this.totalVendas;
        }

        public double CalcularSalarioTotal(double totalVendas, double salario)
        {
            double totalComissao;
            totalComissao = salario + (totalVendas * 0.15);
            return totalComissao;
        }
    }
}
