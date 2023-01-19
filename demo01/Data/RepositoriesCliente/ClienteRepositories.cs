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
        public bool InsertCliente(Clientes clientes)
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

                }) ;

                if (resp == null)
                {
                    return false;
                }

                return true;

            }

        }
        public bool DeleteCliente(Clientes clientes)
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
        public bool EditarCliente(Clientes clientes)
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
        public List<Clientes> ListarClientes()
        {
            using (SqlConnection con = ConnectionProvider.ObterConexao())
            {

                return con.Query<Clientes>("SELECT * FROM cliente ORDER BY CdCliente DESC").ToList();

            }
        }

    }
    #endregion
}