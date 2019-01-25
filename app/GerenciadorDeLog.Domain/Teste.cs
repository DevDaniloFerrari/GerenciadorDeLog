using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeLog.Domain
{
    public class Teste
    {
        public void Iniciar()
        {
            GerenciadorDeLog.ConfigurarCaminhoDoLog(@"C:\Users\Danilo\Desktop\Logs");


            GerenciadorDeLog.Logar(Entities.Situacao.Inicializacao, "Iniciando o teste de Log");

            int zero = 0;

            try
            {
                double valor = 5 / zero;
            }
            catch (Exception exception)
            {
                //GerenciadorDeLog.Logar(Entities.Situacao.Excecao, "Não pode dividir um número por ZERO!");
                GerenciadorDeLog.Logar(Entities.Situacao.Excecao, exception.Message);
            }

        }
    }
}
