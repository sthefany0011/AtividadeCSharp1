using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compraOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string nomeDoProduto1;
            string nomeDoProduto2;
            string nomeDoProduto3;
            int valorDoproduto1;
            int valorDoproduto2;
            int valorDoproduto3;
           


            nomeDoProduto1 = "geladeira";
            valorDoproduto1 = 2502;
            nomeDoProduto2 = "fogão";
            valorDoproduto2 = 1505;
            nomeDoProduto3 = "Microondas";
            valorDoproduto3 = 609;


            Console.WriteLine("Qual é seu nome?");
            string nomeDoUsuario = Console.ReadLine();
            Console.WriteLine("Qual valor do seu Saldo para compra?");
           int Saldo = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual produto deseja, digite o número do produto?");
            Console.WriteLine("1.Geladeira R$2500");
            Console.WriteLine("2.Fogão R$1500");
            Console.WriteLine("3.Microondas R$600");

            int escolha = int.Parse(Console.ReadLine());

            if (escolha == 1)
            { 
                Console.WriteLine("Produto adcionado: " +nomeDoProduto1 + " R$ "+valorDoproduto1+ " Seu saldo: R$ "+ Saldo+" Tem certeza que deseja compra? sim ou não");
                
            }
            if (escolha == 2)
            {
                Console.WriteLine("Produto adcionado: " + nomeDoProduto2 +" R$ "+ valorDoproduto2 + " ,Seu saldo: R$ " + Saldo + " Tem certeza que deseja compra? sim ou não");
            }
            if (escolha == 3)
            {
                Console.WriteLine("Produto adcionado: " + nomeDoProduto3  +" R$ "+valorDoproduto3  + " Seu saldo: R$ " + Saldo + " Tem certeza que deseja compra ? sim ou não");
            }

         
            string resposta = Console.ReadLine();

            if (resposta == "sim" )
            {
                Console.WriteLine("Compra concluida com sucesso!");

            }

          
            else
            {
                Console.WriteLine("Compra cancelada");
            }

            Console.ReadLine();
        }
    }
}
