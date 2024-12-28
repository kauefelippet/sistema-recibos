using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recibo.Util
{
    internal class Validation
    {
        public static bool ValidarCPF(string cpf)
        {
            // Remove special characters from CPF
            cpf = cpf.Replace(".", "").Replace("-", "");

            // Validate if CPF has 11 digits
            if (cpf.Length != 11)
            {
                return false;
            }

            // Validate if all digits are equal 
            if (cpf.All(c => c == cpf[0]))
            {
                return false;
            }

            // Calculates the fist verifier digit
            int sum1 = 0;
            int weight1 = 10;
            for (int i = 0; i < 9; i++)
            {
                sum1 += (cpf[i] - '0') * weight1--;
            }
            int digit1 = 11 - (sum1 % 11);
            if (digit1 == 10 || digit1 == 11)
            {
                digit1 = 0;
            }

            // Calculates the second verifier digit
            int sum2 = 0;
            int weight2 = 11;
            for (int i = 0; i < 10; i++)
            {
                sum2 += (cpf[i] - '0') * weight2--;
            }
            int digit2 = 11 - (sum2 % 11);
            if (digit2 == 10 || digit2 == 11)
            {
                digit2 = 0;
            }

            // Compares the calculated digits with the provided digits
            return cpf[9] == (char)(digit1 + '0') && cpf[10] == (char)(digit2 + '0');
        }

    }
}
