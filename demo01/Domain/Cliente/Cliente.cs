using demo01.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace demo01.Domain.Cliente
{

    public class Cliente
    {
        #region Construtores
        public string CdCliente { get; set; }
        public string NomeCliente { get; set; }

        public string Cpf { get; set; }

        public string Email { get; set; }

        #endregion


        #region Validacao

        public ResultCliente IsValid()
        {
            var messages = new List<string>();
            var regexCpf = new Regex(@"([0-9]{4}[-]?[0-9]{2})|([0-9]{3}[\.]?[0-9]{3}[\.]?[0-9]{3}[-]?[0-9]{2})", RegexOptions.IgnorePatternWhitespace);
            var cpfVaido = regexCpf.IsMatch(Cpf);

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
            if (CdCliente.Length > 10000)
            {
                messages.Add("O código do cliente está irregular, verifique!");
            }
            if (NomeCliente.Length > 50)
            {
                messages.Add("O nome do cliente está irregular, verifique!");
            }
            if (Cpf.Length != 11)
            {
                messages.Add("O Cpf do cliente está irregular, verifique!");
            }
            if (!Email.IsEmail())
            {
                messages.Add("O e-mail inserido não é valido, verifique!");
            }
            if (cpfVaido == false)
            {
                messages.Add("O Cpf inserido não é valido, verifique!");
            }

            if (!Cpf.IsCpf())
            {
                messages.Add("O Cpf está inválido!");
            }

            return new ResultCliente(messages.Count == 0, messages);
        }
    }
    public static class EmailExtension
    {

        //public static bool IsEmpresa(this Cliente value)
        //{
        //    return true;
        //}
        public static bool IsEmail(this string email)
        {
            var regexEmail = new Regex("^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$");
            var emailValido = regexEmail.IsMatch(email);
            if (emailValido == false) return false;
            return true;
        }
    }
    public static class CpfExtension
    {
        // (Extension Method)
        public static bool IsCpf(this string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }

    }
    #endregion
}