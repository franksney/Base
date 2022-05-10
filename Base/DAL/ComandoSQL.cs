using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class ComandoSQL
    {
        private SqlCommand comando;
        private List<ParamentroSQL> parametros;

        public List<ParamentroSQL> Parametros
        {
            get { return parametros; }
            set { parametros = value; }
        }
        
        public SqlCommand Comando
        {
            get { return comando; }
            set { comando = value; }
        }

    }
}
