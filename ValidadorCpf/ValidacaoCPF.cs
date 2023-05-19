using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidadorCpf
{
    class ValidacaoCPF
    {
        public static bool Validacao(string cpf)
        {
            int[] verificarDigito1 = new int[9] {10, 9, 8, 7, 6, 5, 4, 3, 2};
            int[] verificarDigito2 = new int[10] {11, 10, 9, 8, 7, 6, 5, 4, 3, 2};
            string cpf1, cpf2;
            int soma, resultado;

            soma = 0;

            cpf = cpf.Trim();
            cpf = cpf.Replace(".","").Replace("-","");

            if(cpf.Length != 11)
                return false;

            cpf1 = cpf.Substring(0, 10);

            for(int i = 0; i < 9; i++)
                soma += int.Parse(cpf1[i].ToString()) * verificarDigito1[i];
            resultado = soma % 11;

            if(resultado < 2) 
                resultado = 0;
            else
                resultado = 11 - resultado;

            cpf2 = resultado.ToString();
            cpf1 = cpf1 + cpf2;

            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(cpf1[i].ToString()) * verificarDigito2[i];
            resultado = soma % 11;

            if (resultado < 2)
                resultado = 0;
            else
                resultado = 11 - resultado;

            cpf2 = cpf2 + resultado.ToString();
            return cpf.EndsWith(cpf2);
        }
    }
}
