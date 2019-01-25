using GerenciadorDeLog.Domain.Entities;
using GerenciadorDeLog.Domain.Repositories;
using System;
using System.Reflection;

namespace GerenciadorDeLog.Domain
{
    public class GerenciadorDeLog
    {

        public static string CaminhoDoLog { get; set; }
        private static Log log;

        public static void ConfigurarCaminhoDoLog(string caminho)
        {
            CaminhoDoLog = caminho + @"\" + Assembly.GetCallingAssembly().GetName().Name + "_" + DateTime.Now.ToShortDateString().Replace(@"/","-") + ".txt";
        }


        public static void Logar(Situacao situacao, string descricao)
        {
            log = new Log(situacao, descricao);

            if (CaminhoDoLog != null)
                LogRepository.GravarLog(log, CaminhoDoLog);
        }

    }
}
