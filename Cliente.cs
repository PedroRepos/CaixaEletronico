using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Caixa_Eletronico
{
    public class Cliente
    {
        //Deixei mais propriedades disponibilizadas para uso opcional. Caso queira, altere o código com a lógica desejada dentro de "DesserializaJson()";

        protected static string _nome;
        protected static string _loginCliente;
        protected static string _senhaCliente;
        protected static double _saldoConta;

        public string Nome { get; set; }
        public int Idade { get; set; }
        public string CPF { get; set; }
        public string Nascimento { get; set; }
        public string Empresa { get; set; }
        public string EstadoCivil { get; set; }
        public string CEP { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string LoginCliente { get; set; }
        public string SenhaCliente { get; set; }
        public double SaldoConta { get; set; }

        /// <summary>
        /// Performs deserialization of JSON to Object
        /// </summary>
        public static void DesserializaJson()
        {
            try
            {
                string jsonConvertido = File.ReadAllText("D:\\Desktop\\Projeto\\Caixa_Eletronico\\dataClient.json");
                List<Cliente> objetoDesserializado = JsonConvert.DeserializeObject<List<Cliente>>(jsonConvertido);
                foreach (Cliente obj in objetoDesserializado)
                {
                    _nome = obj.Nome;
                    _loginCliente = obj.LoginCliente;
                    _senhaCliente = obj.SenhaCliente;
                    _saldoConta = obj.SaldoConta;
                }
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("O diretório não foi encontrado", e);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Arquivo não encontrado", ex);
            }

        }
    }
}
