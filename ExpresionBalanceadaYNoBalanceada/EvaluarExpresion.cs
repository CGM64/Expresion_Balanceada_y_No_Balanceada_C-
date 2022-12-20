using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpresionBalanceadaYNoBalanceada
{
    static class EvaluarExpresion
    {
        public static string Evaluar(this string expresion)
        {
            //Tamaño del vector
            int tamanio = expresion.Length;
            Stack<char> pila = new Stack<char>();
            StringBuilder concatenar = new StringBuilder();
            bool balanceada1 = false, balanceada2 = false, balanceada3 = false, balanceadaPrincipal = false, balanceadaCierre = false;
            char s = ' ';
            string nuevaExpresion = " ";

            //Separa cada uno de los caracteres ingresados en el vector y se recorren
            for (int i = 0; i < tamanio; i++)
            {
                //Se verifica que se símbolo de apertura
                if (expresion[i] == '{' || expresion[i] == '[' || expresion[i] == '(')
                {
                    //Se apila el símbolo de apertura al stack
                    pila.Push(expresion[i]);

                    //Se concatena el símbolo
                    concatenar.Append(expresion[i]);
                }

                //Se verifica que sea símbolo de cierre
                if (expresion[i] == '}' || expresion[i] == ']' || expresion[i] == ')')
                {
                    //Verifica que la pila no contenga símbolos de apertura
                    //Si la pila está vacía, faltan símbolos de apertura
                    if (pila.Count() == 0)
                    {
                        balanceadaCierre = false;

                        if(balanceadaCierre == false)
                        {
                            balanceadaPrincipal = false;
                        }
                    }
                    else
                    {
                        balanceadaCierre = true;

                        //Se desapilan los símbolos de cierre
                        //Se obtiene el símbolo de cierre correspondiente para evaluarlo con el símbolo de apertura apilado en el stack
                        s = pila.Pop();

                        //Se concatena el símbolo
                        concatenar.Append(expresion[i]);

                        if ((s != '{' && expresion[i] == '}') || (s == '{' && expresion[i] != '}'))
                        {
                            balanceada1 = false;
                        }
                        else
                        {
                            balanceada1 = true;
                        }

                        if ((s != '[' && expresion[i] == ']') || (s == '[' && expresion[i] != ']'))
                        {
                            balanceada2 = false;
                        }
                        else
                        {
                            balanceada2 = true;
                        }

                        if ((s != '(' && expresion[i] == ')') || (s == '(' && expresion[i] != ')'))
                        {
                            balanceada3 = false;
                        }
                        else
                        {
                            balanceada3 = true;
                        }

                        if (balanceada1 == true && balanceada2 == true && balanceada3 == true)
                        {
                            balanceadaPrincipal = true;
                        }
                        else if(balanceada1 == false || balanceada2 == false || balanceada3 == false)
                        {
                            balanceadaPrincipal = false;
                        }
                    }
                }
            }

            //Se comprueba que haya caracteres y que la expresión booleana sea falsa
            //Si hay caracteres dentro de la pila, es una expresión No Balanceada ó si la expresión booleana es falsa es una expresión No Balanceada
            //Si la pila está llena, faltan símbolos de cierre
            if (pila.Count() == 0 && balanceadaPrincipal == true || balanceadaPrincipal == true && pila.Count() == 0)
            {
                Console.WriteLine(" La expresión " + concatenar + " es: Balanceada");
            }
            else if (pila.Count() > 0 && balanceadaPrincipal == false && pila.Count() > 0 || balanceadaPrincipal == false || pila.Count() > 0)
            {
                Console.WriteLine(" La expresión " + concatenar + " es: No Balanceada");
            }

            return nuevaExpresion;
        }
    }
}