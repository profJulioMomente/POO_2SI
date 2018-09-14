using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturasDadosOO
{
    class EstruturaDataTable
    {
        DataTable dt;

        public EstruturaDataTable()
        {
            dt = new DataTable();
            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("Idade", typeof(int));
            dt.Columns.Add("Salario", typeof(double));

        }

        public void adicionarDados()
        {
            Console.WriteLine("Informe o nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe o e-mail:");
            string email = Console.ReadLine();
            Console.WriteLine("Informe a idade:");
            int idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o salario:");
            double salario = Convert.ToDouble(Console.ReadLine());

            DataRow dr = dt.NewRow();
            dr[0] = nome;
            dr[1] = email;
            dr[2] = idade;
            dr[3] = salario;
            dt.Rows.Add(dr);
        }


        public void imprimirDataTable()
        {
            /*for (int i = 0; i < dt.Rows.Count; i++)
            {
                Console.Write(dt.Rows[i]["Nome"] + " - ");
                Console.Write(dt.Rows[i]["Email"] + " - ");
                Console.Write(dt.Rows[i]["Idade"] + " - ");
                Console.Write(dt.Rows[i]["Salario"]);
            }*/

            foreach( DataRow dr in dt.Rows)
            {
                Console.Write(dr["Nome"] + " - ");
                Console.Write(dr["Email"] + " - ");
                Console.Write(dr["Idade"] + " - ");
                Console.Write(dr["Salario"]);
                Console.WriteLine("");
            }
            
        }
    }
}
