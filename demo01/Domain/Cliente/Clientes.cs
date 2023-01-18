using demo01.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01.Domain.Cliente
{
    public class Clientes
    {
        #region Construtores
        public string CdCliente { get; set; }
        public string NomeCliente { get; set; }

        public string Cpf { get; set; }

        #endregion


        #region Validacao

        public ResultCliente IsValid()
        {

            var messages = new List<string>();

            if (string.IsNullOrWhiteSpace(CdCliente))
            {
                messages.Add("O código do cliente está em branco, verifique!");
            }

            if (string.IsNullOrWhiteSpace(NomeCliente))
            {
                messages.Add("O nome do cliente está em branco, verifique!");
            }
            if (string.IsNullOrWhiteSpace(Cpf))
            {
                messages.Add("O Cpf do cliente está em branco, verifique!");
            }
          
            return new ResultCliente(messages.Count == 0, messages);
            

        }
    }
    #endregion
}