using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerarGrupos
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> grupoTotal = new List<Pessoa>();
            int quantPessoas;
            int quantGrupos;
            int pessoasPorGrupo;
            int resto;

            Console.WriteLine("Digite o numero de pessoas que deseja adicionar: ");
            quantPessoas = int.Parse(Console.ReadLine());
            Console.Clear();

            Grupos.AdicionaEmGrupo(grupoTotal, quantPessoas);

            Console.WriteLine("Digite a quantidade de grupos em que deseja separar estas {0} pessoas: ", quantPessoas);
            quantGrupos = int.Parse(Console.ReadLine());
            Console.Clear();
            pessoasPorGrupo = quantPessoas / quantGrupos;
            resto = quantPessoas % quantGrupos;

            Grupos.InicializaGrupos(quantGrupos);
            Grupos.SepararEmGrupos(grupoTotal, quantGrupos, pessoasPorGrupo);
            Grupos.ImprimirGrupos();
        }
    }
}
