using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculadora4
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        } 


        //Digitacion de numeros
        private void leerNumero (string numero)

        {
            Global.unNumeroLeido = true;

            if ((CajaTexto.Text == "+") || (CajaTexto.Text == "-") || (CajaTexto.Text == "*") || (CajaTexto.Text == "/") || (CajaTexto.Text == "^") || (CajaTexto.Text == "0"))
            {
                CajaTexto.Text = "";
                CajaTexto.Text = CajaTexto.Text + numero;
            }
            else
            {
                CajaTexto.Text = CajaTexto.Text + numero;
            }


        }

        protected void btn1_Click(object sender, EventArgs e) // Numero 1
        {
            leerNumero("1");
        }
        protected void btn2_Click(object sender, EventArgs e) // Numero 2
        {
            leerNumero("2");
        }
        protected void btn3_Click(object sender, EventArgs e) // Numero 3
        {
            leerNumero("3");
        }       
        protected void btn4_Click(object sender, EventArgs e) // Numero 4
        {
            leerNumero("4");
        }   
        protected void btn5_Click(object sender, EventArgs e) // Numero 5
        {
            leerNumero("5");
        }       
        protected void btn6_Click(object sender, EventArgs e) // Numero 6
        {
            leerNumero("6");
        }
        protected void btn7_Click(object sender, EventArgs e) // Numero 7
        {
            leerNumero("7");
        }
        protected void btn8_Click(object sender, EventArgs e) // Numero 8
        {
            leerNumero("8");
        }
        protected void btn9_Click(object sender, EventArgs e) // Numero 9
        {
            leerNumero("9");
        }       
        protected void Button24_Click(object sender, EventArgs e) // numero 0
        {
            if (CajaTexto.Text == "0") { return; }


            else { leerNumero("0"); }
        }     

        // Operaciones Basicas
        protected void btnSuma_Click(object sender, EventArgs e) // Suma
        {
            Global.Valor1 = Convert.ToDouble(CajaTexto.Text);
            CajaTexto.Text = "";
            Global.O = '+';
            CajaTexto.Text += Global.O;
        } 
        protected void btnResta_Click(object sender, EventArgs e) // Resta
        {
            Global.Valor1 = Convert.ToDouble(CajaTexto.Text);
            CajaTexto.Text = "";
            Global.O = '-';
            CajaTexto.Text += Global.O;
        }       
        protected void btnMultiplicacion_Click(object sender, EventArgs e) // Multiplicacion
        {
            Global.Valor1 = Convert.ToDouble(CajaTexto.Text);
            CajaTexto.Text = "";
            Global.O = '*';
            CajaTexto.Text += Global.O;
        }
        protected void btnDivision_Click(object sender, EventArgs e) // Division
        {
            Global.Valor1 = Convert.ToDouble(CajaTexto.Text);
            CajaTexto.Text = "";
            Global.O = '/';
            CajaTexto.Text += Global.O;
        }
        protected void btnIgual_Click(object sender, EventArgs e) // Boton de Igual
        {
            Global.Valor2 = Convert.ToDouble(CajaTexto.Text);
            CajaTexto.Text = "";
            if(Global.O == '+')
            {
                Global.Resultado = Global.Valor1 + Global.Valor2;
                CajaTexto.Text += Global.Resultado;
                Global.Valor1 = Global.Resultado;
            } 
            else if(Global.O == '/')
            {

                if (Global.Valor2 == 0) { ErrorLabel1.Text = "Error: No se puede dividir entre 0."; Global.Resultado = 0; }//*
                else {
                    Global.Resultado = Global.Valor1 / Global.Valor2;
                    CajaTexto.Text += Global.Resultado;
                    Global.Valor1 = Global.Resultado;
                }

                
            }
            else if (Global.O == '-') 
            {


                Global.Resultado = Global.Valor1 - Global.Valor2;
                CajaTexto.Text += Global.Resultado;
                Global.Valor1 = Global.Resultado;
            }


            else if (Global.O == '^')
            {
                Global.Resultado = Math.Pow(Global.Valor1, Global.Valor2);
                CajaTexto.Text += Global.Resultado;
                Global.Valor1 = Global.Resultado;

            }

            else
            {
                Global.Resultado = Global.Valor1 * Global.Valor2;
                CajaTexto.Text += Global.Resultado;
                Global.Valor1 = Global.Resultado;
            }

        }



        // Metodos de Eliminacion de Datos y el punto
        protected void btnLimpiarPantalla_Click(object sender, EventArgs e) // Limpiar Pantalla
        {
            CajaTexto.Text = "0";
            ErrorLabel1.Text = "-";
        }

        protected void btnBorrar_Click(object sender, EventArgs e) // Eliminar Digitos
        {
            if (CajaTexto.Text.Length > 1)
            {
                string txtResultado = CajaTexto.Text;
                txtResultado = txtResultado.Substring(0, txtResultado.Length - 1); // Borra Caracteres
                CajaTexto.Text = txtResultado;

                if (txtResultado.Length == 1 && txtResultado.Contains("-")) // Borra si solo queda un "-"
                {
                    CajaTexto.Text = "";
                } else
                {
                    CajaTexto.Text = txtResultado;
                }
            } else
            {
                CajaTexto.Text = "0";
                ErrorLabel1.Text = "-";
            }
        }

        protected void Button25_Click(object sender, EventArgs e) // .
        {
            if (CajaTexto.Text.Contains(","))
            {
                return;
            }
            CajaTexto.Text += ",";
        }

        // Operaciones Cientificas
        protected void btnPotencia_Click(object sender, EventArgs e) // x²
        {
            if (Global.unNumeroLeido is false)
            {
                ErrorLabel1.Text = "Error: Digita antes X valor y luego la operacion (x²)";

            }

            else
            {
                double num = Convert.ToDouble(CajaTexto.Text);
                double resu = Math.Pow(num, 2);
                CajaTexto.Text = resu.ToString();
                ErrorLabel1.Text = "-";
            }

        }

        protected void btnLog_Click(object sender, EventArgs e) // Log
        {
            if (Global.unNumeroLeido is false)
            {
                ErrorLabel1.Text = "Error: Digita antes X valor y luego la operacion (Log)";

            }
            else
            {
                double num = Convert.ToDouble(CajaTexto.Text);
                double resu = Math.Log10(num);
                CajaTexto.Text = resu.ToString();
                ErrorLabel1.Text = "-";
            }

            
        }

        protected void btnBase10_Click(object sender, EventArgs e) // 10^x
        {
            if (Global.unNumeroLeido is false)
            {
                ErrorLabel1.Text = "Error: Digita antes X valor y luego la operacion (10^x)";

            }
            else

            {
                double num = Convert.ToDouble(CajaTexto.Text);
                double resu = Math.Pow(10, num);
                CajaTexto.Text = resu.ToString();
                ErrorLabel1.Text = "-";

            }

                
        } 

        protected void btnPotencia2_Click(object sender, EventArgs e) // x^y
        {
            if (Global.unNumeroLeido is false)
            {
                ErrorLabel1.Text = "Error: Digita antes X valor y luego la operacion (x^y)";

            }

            else
            {
                Global.Valor1 = Convert.ToDouble(CajaTexto.Text);
                CajaTexto.Text = "";
                Global.O = '^';
                CajaTexto.Text += Global.O;
                ErrorLabel1.Text = "-";
            }
            


        } 

        protected void btnRaiz_Click(object sender, EventArgs e)
        {
        if (Global.unNumeroLeido is false)
            {
                ErrorLabel1.Text = "Error: Digita antes X valor y luego la operacion (²√)";

            }
        else
            {
                double num = Convert.ToDouble(CajaTexto.Text);
                double resu = Math.Sqrt(num);
                CajaTexto.Text = resu.ToString();
                ErrorLabel1.Text = "-";

            }
               

            
        } // Raiz ²√

        protected void btnFactorial_Click(object sender, EventArgs e)
        {

            if (Global.unNumeroLeido is false)
            {
                ErrorLabel1.Text = "Error: Digita antes X valor y luego la operacion (n!)";

            }

            else
            {
                double valor = Convert.ToDouble(CajaTexto.Text);
                if (valor < 0)
                {
                    CajaTexto.Text = "Error de syntaxis";
                }
                else
                {
                    int resultado = 1;
                    for (int i = 2; i <= valor; i++)
                    {
                        resultado *= i;
                    }
                    CajaTexto.Text = resultado.ToString();
                }
                ErrorLabel1.Text = "-";

            }

            

            
            
        } // n!
        protected void Button23_Click(object sender, EventArgs e) // Intercambiar el simbolo actual +/-
        {
            if (!string.IsNullOrEmpty(CajaTexto.Text))
            {
                if (CajaTexto.Text.StartsWith("-"))
                {
                    // Si el numero es negativo lo volvemos posito
                    CajaTexto.Text = CajaTexto.Text.Substring(1);
                }
                else
                {
                    // si el numero es positivo se agrega un menos (-) 
                    CajaTexto.Text = "-" + CajaTexto.Text;
                }
            }
        }
    }
}