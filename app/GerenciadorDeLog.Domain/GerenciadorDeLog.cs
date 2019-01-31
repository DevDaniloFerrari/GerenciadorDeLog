using GerenciadorDeLog.Domain.Entities;
using GerenciadorDeLog.Domain.Repositories;
using System;
using System.Reflection;

namespace GerenciadorDeLog.Domain
{
    public class GerenciadorDeLog
    {

        private static string CaminhoDoLog { get; set; }
        private static Log log;

        /// <summary>
        /// Configura o caminho para onde os Logs serão salvos.
        /// Colocar apenas o diretório. O (.txt) será criado automaticamente.
        /// </summary>
        /// <param string="caminho">Caminho onde os Logs serão salvos.</param>
        public static void ConfigurarCaminhoDoLog(string caminho)
        {
            CaminhoDoLog = caminho + @"\" + Assembly.GetCallingAssembly().GetName().Name + "_" + DateTime.Now.ToShortDateString().Replace(@"/","-") + ".txt";
        }

        /// <summary>
        /// Grava no (.txt) a situação e a descrição do Log.
        /// </summary>
        /// <param Situacao="situacao">Situação do Log.</param>
        /// <param string="descricao">Frase para descrever o Log.</param>
        public static void Logar(Situacao situacao, string descricao)
        {
            log = new Log(situacao, descricao);

            if (CaminhoDoLog != null)
                LogRepository.GravarLog(log, CaminhoDoLog);
        }

    }
}
