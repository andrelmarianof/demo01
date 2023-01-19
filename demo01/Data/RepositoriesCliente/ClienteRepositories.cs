using demo01.Data.Provider;
using demo01.Domain.Produtos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Dapper;
using demo01.Domain.Cliente;

namespace demo01.Data.RepositoriesCliente
{
    public class ClienteRepository
    {

        #region RepositoryDapper
        public bool InsertCliente(Cliente clientes)
        {
            using (SqlConnection con = ConnectionProvider.ObterConexao())
            {

                var sql = @"
 INSERT INTO cliente
    (CdCliente,
    NomeCliente,
    Cpf)
 OUTPUT INSERTED.CdCliente
 VALUES
    (@cdcliente,
     @nomecliente,
     @cpf)";

                var resp = con.ExecuteScalar(sql, new
                {
                    cdcliente = clientes.CdCliente,
                    nomecliente = clientes.NomeCliente,
                    cpf = clientes.Cpf

                });

                if (resp == null)
                {
                    return false;
                }

                return true;

            }

        }
        public bool DeleteCliente(Cliente clientes)
        {
            using (SqlConnection con = ConnectionProvider.ObterConexao())
            {

                var sql = @"
 DELETE FROM cliente
 WHERE CdCliente = @cdcliente";

                var resp = con.ExecuteScalar(sql, new
                {
                    cdcliente = clientes.CdCliente,
                });
                if (resp == null)
                {
                    return false;
                }
                return true;
            }
        }
        public bool EditarCliente(Cliente clientes)
        {
            using (SqlConnection con = ConnectionProvider.ObterConexao())
            {

                var sql = @"
 UPDATE cliente
SET 
    NomeCliente = @nomecliente,
    Cpf = @cpf
OUTPUT inserted.CdCliente
WHERE 
    CdCliente = @cdcliente";

                var resp = con.ExecuteScalar(sql, new
                {
                    nomecliente = clientes.NomeCliente,
                    cpf = clientes.Cpf,
                    cdcliente = clientes.CdCliente
                });
                if (resp == null)
                {
                    return false;
                }
                return true;
            }
        }
        public List<Cliente> ListarClientes(string columnSort)
        {
            using (SqlConnection con = ConnectionProvider.ObterConexao())
            {

                //return con.Query<Cliente>($"SELECT * FROM cliente ORDER BY {columnSort} DESC").ToList();

                var query = new StringBuilder();
                query.AppendLine("SELECT * FROM cliente");
                query.AppendLine("/**orderby**/");

                var queryBuilder = new SqlBuilder();
                var template = queryBuilder.AddTemplate(query.ToString());
                queryBuilder.OrderBy(columnSort);

                return con.Query<Cliente>(template.RawSql, template.Parameters).ToList();
            }

        }

    }
    #endregion
}