using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAvaliativa3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalComissao;
            Vendedor vendedor = new Vendedor();  //instanciar um objeto da classe vendedor

            Console.WriteLine("Digite o nome do funcionário, seu salário fixo e seu total de vendas");
            vendedor.setNome(Console.ReadLine());
            vendedor.setSalario(double.Parse(Console.ReadLine()));
            vendedor.setTotalVendas(double.Parse(Console.ReadLine()));

            totalComissao = vendedor.CalcularSalarioTotal(vendedor.getTotalVendas(),vendedor.getSalario());

            Console.WriteLine("O funcionário " + vendedor.getNome() + " irá receber: " + totalComissao.ToString("F"));
            Console.WriteLine("");
        }
    }
}
