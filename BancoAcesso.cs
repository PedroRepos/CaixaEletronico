using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa_Eletronico
{
    class BancoAcesso : Cliente
    {
        /// <summary>
        /// Bank operations begin
        /// </summary>
        public static void BancoIncio()
        {
            bool menu = true;

            while (menu)
            {
                Console.WriteLine($"OLÁ {_nome.ToUpper()}, SEJA BEM VINDO! DIGITE A OPÇÃO DESEJADA!");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("1 - SALDO CONTA CORRENTE\n2 - SACAR\n3 - DEPOSITAR\n4 - TRANSFERIR\nCTRL + C - ENCERRAR");
                int escolha = Convert.ToInt32(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        ExibirSaldo();
                        break;
                    case 2:
                        Saque();
                        break;
                    case 3:
                        Depositar();
                        break;
                    case 4:
                        Transferir();
                        break;
                    case 5:
                        InicioPrograma.Start();
                        break;
                }
            }
        }

        /// <summary>
        // Show current balance
        /// </summary>
        public static void ExibirSaldo()
        {
            Console.Clear();
            Seguranca.ValidaUsuario();
            Console.Clear();

            Console.WriteLine("VOCÊ SÓ PODERÁ VISUALIZAR ESTA TELA POR 3 SEGUNDOS | PRESSIONE QUALQUER TECLA.");
            Console.ReadKey();
            Console.WriteLine($"Saldo Atual: {_saldoConta}");
            Thread.Sleep(3000);
            Console.Clear();
        }

        /// <summary>
        /// Withdraw from the account
        /// </summary>
        public static void Saque()
        {
            bool testeValor = true;
            double valorDoSaque;

            Console.Clear();
            Seguranca.ValidaUsuario();
            Console.Clear();

            while (testeValor)
            {
                Console.Write("DIGITE O VALOR: ");
                valorDoSaque = Convert.ToDouble(Console.ReadLine());

                if (valorDoSaque >= _saldoConta)
                {
                    Console.WriteLine("O VALOR DESEJADO É MAIOR QUE O SALDO ATUAL\nTENTE NOVAMENTE");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
                else
                {
                    _saldoConta -= valorDoSaque;
                    testeValor = false;
                }
            }

            Console.WriteLine("REALIZANDO SAQUE... ");
            Thread.Sleep(2000);
            Console.WriteLine("CONTANDO AS CÉDULAS... ");
            Thread.Sleep(2000);
            Console.WriteLine("SAQUE REALIZADO COM SUCESSO! ");
            Escolhas();
        }

        /// <summary>
        /// Makes the deposit of some value in the user's account
        /// </summary>
        public static void Depositar()
        {
            Console.Clear();
            Seguranca.ValidaUsuario();
            Console.Clear();

            Console.WriteLine("DEPÓSITO");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.Write("INSIRA O VALOR DESEJADO: ");
            double valorDeposito = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("REALIZANDO TRANSAÇÃO...");
            Thread.Sleep(1500);

            _saldoConta += valorDeposito;

            Escolhas();
        }
        /// <summary>
        /// Transfer to another account | W.I.P
        /// </summary>
        public static void Transferir()
        {
            ///W.I.P
        }

        /// <summary>
        /// Choice menu for the user to determine
        /// </summary>
        public static void Escolhas()
        {
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("DESEJA EXIBIR O SALDO? 1 - SIM | 2 - INICIO | CTRL + C - ENCERRAR");
            int escolha = Convert.ToInt32(Console.ReadLine());

            if (escolha == 1)
            {
                ExibirSaldo();
            }
            else if (escolha == 2)
            {
                Console.Clear();
                BancoIncio();
            }
        }
    }
}
