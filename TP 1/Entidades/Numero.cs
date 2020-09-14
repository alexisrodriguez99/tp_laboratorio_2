using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Numero
    {
        double numero;
        /// <summary>
        /// Inicializa 'numero'
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }
        /// <summary>
        /// Guarda el valor ingresaso en 'numero'
        /// </summary>
        /// <param name="numero">Es el valor que se desea guardar en 'numero'</param>
        public Numero(double numero):this()
        {
            //this.numero = numero;
            SetNumero = Convert.ToString(numero);
        }
        /// <summary>
        /// Guarda el valor ingresaso en 'numero'
        /// </summary>
        /// <param name="numero">Es el valor que se desea guardar en 'numero'</param>
        public Numero(string numero):this()
        {
            
            SetNumero = numero;                                  
        }                                 
        /// <summary>
        /// Valida el numero ingresado
        /// </summary>
        /// <param name="strNumero">El numero a validar</param>
        /// <returns>Retorna el numero validado o 0 si era un numero invalido</returns>
        double ValidarNumero(string strNumero)
        {
            bool validar;
            double dblNumero;

            validar = double.TryParse(strNumero, out dblNumero);
            if (validar == false)
            {
                dblNumero = 0;
            }
            return dblNumero;
        }
        /// <summary>
        /// Guarda un valor en 'numero'
        /// </summary>
        public string SetNumero
        {
            set { numero = ValidarNumero(value); }
        }
        /// <summary>
        /// Realiza la conversion de un numero binario a decimal
        /// </summary>
        /// <param name="binario">Es el valor que se desea pasar a decimal</param>
        /// <returns>Retorna el valor de la conversion o 'Valor invalido' en el caso de que haya ocurrido un error</returns>
        public static string BinarioDecimal(string binario)
        { 
            int i;
            int acumulador = 0;
            int cantidad = binario.Length;
            bool esBinario;
            esBinario=EsBinario(binario);
            if(esBinario==true)
            {
                for (i = 0; i < binario.Length; i++)
                {
                    if (binario[cantidad - 1] == '1')
                    {
                        acumulador = acumulador + Convert.ToInt32(Math.Pow(2, i));
                        //numero = numero + (2 ^ i);
                    }
                    cantidad--;

                }
                binario = Convert.ToString(acumulador);
            }
            else
            {
                binario = "Valor invalido";
            }
           
            return binario;
        }
        /// <summary>
        /// Realiza la conversion de un numero binario a decimal
        /// </summary>
        /// <param name="numero">Es el valor que se desea pasar a binario</param>
        /// <returns>Retorna el valor de la conversion o 'Valor invalido' en el caso de que haya ocurrido un error</returns>
        public static string DecimalBinario(string numero)
        {

            double resto;
            string binario = "";
            int numeroEntero;
            numeroEntero = Convert.ToInt32(numero);



            if (numeroEntero > -1)
            {
                if(numero=="0")
                {
                    binario = "0";
                }
                else
                {
                    while (numeroEntero >= 1)
                {
                    resto = numeroEntero % 2;
                    numeroEntero = numeroEntero / 2;
                    binario = Convert.ToString(resto) + binario;
                }
                }
                
                
            }
            else
            {
                binario = "Valor invalido";
            }


            return binario;
        }
        /// <summary>
        /// Realiza la conversion de un numero binario a decimal
        /// </summary>
        /// <param name="numero">Es el valor que se desea pasar a binario</param>
        /// <returns>Retorna el valor de la conversion o 'Valor invalido' en el caso de que haya ocurrido un error</returns>
        public static string DecimalBinario(double numero)
        {
            string binario;
            binario = DecimalBinario(Convert.ToString(numero));

            return binario;
        }
        /// <summary>
        /// Valida que el numero sea un binario
        /// </summary>
        /// <param name="binario">El numero que se desea validar </param>
        /// <returns>retorna 'true', en el caso de que de si sea un binario, o 'false' en el caso contrario</returns>
        private  static bool EsBinario(string binario)
        {
            bool validar = true;

            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i] != '1' && binario[i] != '0')
                {
                    if(binario[i]=='.')
                    {
                        break;
                    }
                    else
                    {
                        validar = false;
                        break;
                    }
                   
                }


            }
            return validar;
        }
        /// <summary>
        /// Realiza la resta de los numeros
        /// </summary>
        /// <param name="n1">El primer numero ingresado</param>
        /// <param name="n2">El segundo numero ingresado</param>
        /// <returns>retorna el valor de la operacion</returns>
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }
        /// <summary>
        /// Realiza la suma de los numeros
        /// </summary>
        /// <param name="n1">El primer numero ingresado</param>
        /// <param name="n2">El segundo numero ingresado</param>
        /// <returns>retorna el valor de la operacion</returns>
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;

        }
        /// <summary>
        /// Realiza la multiplicacion de los numeros
        /// </summary>
        /// <param name="n1">El primer numero ingresado</param>
        /// <param name="n2">El segundo numero ingresado</param>
        /// <returns>retorna el valor de la operacion</returns>
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;

        }
        /// <summary>
        /// Realiza la division de los numeros
        /// </summary>
        /// <param name="n1">El primer numero ingresado</param>
        /// <param name="n2">El segundo numero ingresado</param>
        /// <returns>retorna el valor de la operacion 0 un valor muy chico en el caso de que el segundo numero valga 0</returns>
        public static double operator /(Numero n1, Numero n2)
        {
            double resultado;
            if (n2.numero == 0)
            {
                resultado = double.MinValue;
            }
            else
            {
                resultado = n1.numero / n2.numero;

            }
            return resultado;

        }
    }
}
