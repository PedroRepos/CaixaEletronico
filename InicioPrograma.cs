using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa_Eletronico
{
    class InicioPrograma
    {
        /// <summary>
        /// Start the program
        /// </summary>
        public static void Start()
        {
            Cliente.DesserializaJson();
            Seguranca.ValidaUsuario();
            BancoAcesso.BancoIncio();
        }
    }
}
