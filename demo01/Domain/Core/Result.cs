using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01.Domain.Core
{
    #region Result
    public class Result
    {
       
        public bool Success { get; }
        public List<string> Messages { get; }

        public Result(bool success, List<string> messages)
        {
            Success = success;
            Messages = messages;
        }

        public Result(bool success, string message)
        {
            Success = success;
            Messages = new List<string>() { message };
        }
    }
    #endregion

    #region ResultCliente
    public class ResultCliente
    {

        public bool Success { get; }
        public List<string> Messages { get; }

        public ResultCliente(bool success, List<string> messages)
        {
            Success = success;
            Messages = messages;
        }

        public ResultCliente(bool success, string message)
        {
            Success = success;
            Messages = new List<string>() { message };
        }
    }
    public class ResultPedido
    {

        public bool Success { get; }
        public List<string> Messages { get; }

        public ResultPedido(bool success, List<string> messages)
        {
            Success = success;
            Messages = messages;
        }

        public ResultPedido(bool success, string message)
        {
            Success = success;
            Messages = new List<string>() { message };
        }
    }
    #endregion

}
