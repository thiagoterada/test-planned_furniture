using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Etec.MoveisPlanejados.UI.DAO
{
    class Banco
    {
        public DataTable retornarCliente()
        {
            MySqlConnection msc = new MySqlConnection(); 
            msc.ConnectionString = "server= localhost;user id=root; password=''; database=loja_moveis;";
            msc.Open();
            MySqlDataAdapter msda = new MySqlDataAdapter("select*from cliente", msc);
            DataSet ds = new DataSet();  
            msda.Fill(ds);
            msc.Close(); 
            return ds.Tables[0];
        }

        public void cadastrarCliente(string nome, string cpf, string rg, string sexo, string tel, string cel, string uf, string cidade, string bairro, string logradouro, int numero, string cep, string compl)
        {
            MySqlConnection msc = new MySqlConnection(); 
            msc.ConnectionString = "server= localhost;user id=root; password=''; database=loja_moveis;";
            msc.Open();
            MySqlCommand mscommand = new MySqlCommand("INSERT INTO `loja_moveis`.`CLIENTE` (`nome`, `cpf`, `rg`, `sexo`, `tel`, `cel`, `uf`, `cidade`, `bairro`, `logradouro`, `numero`, `cep`, `compl`) VALUES ('"+nome+"', '"+cpf+"', '"+rg+"', '"+sexo+"','"+tel+"', '"+cel+"', '"+uf+"', '"+cidade+"', '"+bairro+"', '"+logradouro+"', '"+numero+"', '"+cep+"', '"+compl+"');");
            mscommand.Connection = msc; 
            mscommand.ExecuteNonQuery();
            msc.Close();
        }

        public DataTable retornarTipoMovel()
        {
            MySqlConnection msc = new MySqlConnection();
            msc.ConnectionString = "server= localhost;user id=root; password=''; database=loja_moveis;";
            msc.Open();
            MySqlDataAdapter msda = new MySqlDataAdapter("select*from TIPO_MOVEL", msc);
            DataSet ds = new DataSet();
            msda.Fill(ds);
            msc.Close();
            return ds.Tables[0];
        }

        public void cadastrarTipoMovel(string nome, string descricao)
        {
            MySqlConnection msc = new MySqlConnection();
            msc.ConnectionString = "server= localhost;user id=root; password=''; database=loja_moveis;";
            msc.Open();
            MySqlCommand mscommand = new MySqlCommand("INSERT INTO `loja_moveis`.`TIPO_MOVEL` (`nome`, `dsMov`) VALUES ('"+nome+"', '"+descricao+"');");
            mscommand.Connection = msc;
            mscommand.ExecuteNonQuery();
            msc.Close();
        }

        public DataTable retornarProjeto()
        {
            MySqlConnection msc = new MySqlConnection();
            msc.ConnectionString = "server= localhost;user id=root; password=''; database=loja_moveis;";
            msc.Open();
            MySqlDataAdapter msda = new MySqlDataAdapter("select*from TIPO_MOVEL", msc);
            DataSet ds = new DataSet();
            msda.Fill(ds);
            msc.Close();
            return ds.Tables[0];
        }

        public void cadastrarProjeto(int idTipoMov, int idCli, string nome, string dsProj, float preco, DateTime dt, DateTime dt_entrega)
        {
            MySqlConnection msc = new MySqlConnection();
            msc.ConnectionString = "server= localhost;user id=root; password=''; database=loja_moveis;";
            msc.Open();
            MySqlCommand mscommand = new MySqlCommand("INSERT INTO `loja_moveis`.`PROJETO` (`idTipoMov`, `idCli`, `nome`, `dsProj`, `preco`, `dt`, `dt_entrega`) VALUES ('"+idTipoMov+"', '"+idCli+"', '"+nome+"', '"+dsProj+"', '"+preco+"', '"+dt.ToString("yyyy-MM-dd") + "', '"+dt_entrega.ToString("yyyy-MM-dd")+ "');");
            mscommand.Connection = msc;
            mscommand.ExecuteNonQuery();
            msc.Close();
        }
    }
}
