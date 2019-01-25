using GerenciadorDeLog.Domain.Entities;
using System.IO;

namespace GerenciadorDeLog.Domain.Repositories
{
    public class LogRepository
    {
        public static void GravarLog(Log log, string caminhoDoLog)
        {

            using (var streamWriter = new StreamWriter(caminhoDoLog, true))
            {
                streamWriter.WriteLine(log.Imprimir());
            }

        }
    }
}
