using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public static class Calculadora
    {
        /// <summary>
        /// Se encarga de realizar las operaciones matematicas
        /// </summary>
        /// <param name="num1">es el primer numero ingresado</param>
        /// <param name="num2">es el segundo numero ingresado</param>
        /// <param name="operador">la operacion que se desea ejecutar</param>
        /// <returns>retorna el resultado de dicha operacion</returns>
        static public double Operar(Numero num1, Numero num2, string operador)
        {
            double resultado = 0;
         if(operador=="")
            {
                operador = "+";
            }
         else
            {
              operador= ValidarOperador(Convert.ToChar( operador));
            }

            switch (operador)
            {
                case "+":
                    {
                        resultado = num1 + num2;
                        break;
                    }
                case "-":
                    {
                        resultado = num1 - num2;

                        break;
                    }
                case "*":
                    {
                        resultado = num1 * num2;
                        break;
                    }
                case "/":
                    {
                        resultado = num1 / num2;
                        break;
                    }
                

            }
            return resultado;
        }
        /// <summary>
        /// Valida el operador ingresado
        /// </summary>
        /// <param name="operador">el operador a validar</param>
        /// <returns>retorna el operador ya validado</returns>
        static string ValidarOperador(char operador)
        {
            string validar;

            switch (operador)
            {
                case '+':
                    {
                        validar = "+";
                        break;
                    }
                case '-':
                    {
                        validar = "-";
                        break;
                    }
                case '*':
                    {
                        validar = "*";
                        break;
                    }
                case '/':
                    {
                        validar = "/";
                        break;
                    }
                default:
                    {
                        validar = "+";
                        break;
                    }

            }
            return validar;
        }
    }
}
