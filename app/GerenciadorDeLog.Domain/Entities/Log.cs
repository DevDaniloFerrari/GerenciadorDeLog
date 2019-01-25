using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeLog.Domain.Entities
{
    public class Log
    {
        public Log(Situacao situacao, string descricao)
        {
            Situacao = situacao;
            Data = DateTime.Now;
            Descricao = descricao;
        }

        public Situacao Situacao { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        

        public string Imprimir()
        {
            return String.Format(
                                 
                                 "Situacao: {0}\r\n"+
                                 "Data: {1}\r\n" +
                                 "Descricao: {2}\r\n" +
                                 "------------------------------------------------------------------------"

                                 ,this.Situacao
                                 ,this.Data
                                 ,this.Descricao
                                 
                                 );
        }
    }
}
