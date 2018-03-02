using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class TabelaDados
    {

        public DataTable dt;

        public TabelaDados()
        {
            dt = new DataTable();
            definirEstrutura();
        }

        public void definirEstrutura()
        {
            dt.Columns.Add("Nome" , typeof(string));
            dt.Columns.Add("Idade" , typeof(int));
            dt.Columns.Add("Email" , typeof(string));
        }

        public void preencherTabela(Pessoa P)
        {
            dt.Rows.Add(P.Nome , P.idade , P.Nome + "@exemplo.com");
            
        }

        public void displayTabela()
        {
            foreach(DataRow dr in dt.Rows)
            {
                Console.WriteLine(dr["Nome"].ToString() + " - " +
                                dr["Idade"].ToString() + " - " +
                                dr["Email"].ToString());
            }
        }
    }
}
