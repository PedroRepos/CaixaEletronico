using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa_Eletronico
{
    public class Seguranca : Cliente
    {
        /// <summary>
        /// Authenticates and confirms the current user
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public static void ValidaUsuario()
        {
            bool acesso = true;
            int contador = 3;

            while (acesso)
            {
                Console.WriteLine("ENTRE COM AS SUAS CREDENCIAIS");
                Console.Write("LOGIN: ");
                string login = Console.ReadLine();
                Console.Write("SENHA: ");
                string senha = Console.ReadLine();

                if (login == _loginCliente && senha == _senhaCliente)
                {
                    Console.Clear();
                    Console.WriteLine("SUCESSO!");
                    Thread.Sleep(1000);
                    acesso = false;
                    Console.Clear();
                }
                else if (contador <= 0)
                {
                    throw new ArgumentException("TENTATIVAS EXCEDIDAS! USUÁRIO BLOQUEADO! VOLTANDO AO INÍCIO...");
                }
                else
                {
                    Console.WriteLine("INCORRETO! TENTE NOVAMENTE!");
                    Thread.Sleep(1000);
                    Console.Clear();
                    contador--;
                }
            }
        }
    }
}
