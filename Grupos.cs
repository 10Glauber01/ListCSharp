using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerarGrupos
{
    public class Grupos
    {
        public static List<List<Pessoa>> grupos = new List<List<Pessoa>>();

        public List<Pessoa> grupo = new List<Pessoa>();

        public static void AdicionaEmGrupo(List<Pessoa> grupoTotal, int quantPessoas)
        {
            for (int i = 0; i < quantPessoas; i++)
            {

                Console.WriteLine("Digite o nome da pessoa que deseja adicionar : ");
                grupoTotal.Add(new Pessoa() { Nome = Console.ReadLine() });
            }
        }

        // a ideia é criar uma lista contendo X listas de pessoas aleatórias e sortear a posição em que vou adicionar 
        // o elemento na lista.

        public static void SepararEmGrupos(List<Pessoa> grupoTotal, int quantGrupos, int pessoasPorGrupo)
        {
            Random grupoAleatorio = new Random();
            var auxilia = true;
            int auxRand;

            foreach (var pessoas in grupoTotal)
            {
                //necessario fazer esse while para verificar a quantidade de objetos Pessoa na lista de listas GRUPOS.
                //se a quantidade de objetos for maior que o numero maximo de pessoas por grupo ele calcula o 
                //valor aleatorio novamente e verifica para adicionar na lista GRUPOS. 
                auxRand = grupoAleatorio.Next(0,pessoasPorGrupo);
                while (auxilia == true)
                {
                    if (grupos[auxRand].Count < pessoasPorGrupo)
                    {
                        //Adiciona na posição grupoAleatorio da lista de listas.
                        grupos[auxRand].Add(pessoas);
                        auxilia = false;
                    }
                    else
                    {
                        auxRand = grupoAleatorio.Next(pessoasPorGrupo);
                    }
                }
                auxilia = true;
            }
        }

        public static void InicializaGrupos(int pessoasPorGrupo)
        {
            for (int i = 0; i <= pessoasPorGrupo; i++)
			{
                grupos.Add(new List<Pessoa>());
			}
        }



        public static void ImprimirGrupos()
        {
            int i = 0;

            foreach (var grupoMenor in grupos)
            {

                foreach (var pessoas in grupoMenor)
                {
                    Console.WriteLine("{0} faz parte do grupo : {1}", pessoas.Nome, i);
                }
                i = i+1;
                
            }
            Console.ReadKey();
        }


    }
}