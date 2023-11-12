using System;
using System.Collections.Generic;
using System.Data;
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

        protected void btn1_Click(object sender, EventArgs e) // Numero 1
        {
            if((CajaTexto.Text == "+") || (CajaTexto.Text == "-") || (CajaTexto.Text == "*") || (CajaTexto.Text == "/"))
            {
                CajaTexto.Text = "";
                CajaTexto.Text = CajaTexto.Text + btn1.Text;
            } else
            {
                CajaTexto.Text = CajaTexto.Text + btn1.Text;
            }
        }
        protected void btn2_Click(object sender, EventArgs e) // Numero 2
        {
            if ((CajaTexto.Text == "+") || (CajaTexto.Text == "-") || (CajaTexto.Text == "*") || (CajaTexto.Text == "/"))
            {
                CajaTexto.Text = "";
                CajaTexto.Text = CajaTexto.Text + btn2.Text;
            }
            else
            {
                CajaTexto.Text = CajaTexto.Text + btn2.Text;
            }
        }
        protected void btn3_Click(object sender, EventArgs e) // Numero 3
        {
            if ((CajaTexto.Text == "+") || (CajaTexto.Text == "-") || (CajaTexto.Text == "*") || (CajaTexto.Text == "/"))
            {
                CajaTexto.Text = "";
                CajaTexto.Text = CajaTexto.Text + btn3.Text;
            }
            else
            {
                CajaTexto.Text = CajaTexto.Text + btn3.Text;
            }
        }       
        protected void btn4_Click(object sender, EventArgs e) // Numero 4
        {
            if ((CajaTexto.Text == "+") || (CajaTexto.Text == "-") || (CajaTexto.Text == "*") || (CajaTexto.Text == "/"))
            {
                CajaTexto.Text = "";
                CajaTexto.Text = CajaTexto.Text + btn4.Text;
            }
            else
            {
                CajaTexto.Text = CajaTexto.Text + btn4.Text;
            }
        }   
        protected void btn5_Click(object sender, EventArgs e) // Numero 5
        {
            if ((CajaTexto.Text == "+") || (CajaTexto.Text == "-") || (CajaTexto.Text == "*") || (CajaTexto.Text == "/"))
            {
                CajaTexto.Text = "";
                CajaTexto.Text = CajaTexto.Text + btn5.Text;
            }
            else
            {
                CajaTexto.Text = CajaTexto.Text + btn5.Text;
            }
        }       
        protected void btn6_Click(object sender, EventArgs e) // Numero 6
        {
            if ((CajaTexto.Text == "+") || (CajaTexto.Text == "-") || (CajaTexto.Text == "*") || (CajaTexto.Text == "/"))
            {
                CajaTexto.Text = "";
                CajaTexto.Text = CajaTexto.Text + btn6.Text;
            }
            else
            {
                CajaTexto.Text = CajaTexto.Text + btn6.Text;
            }
        }
        protected void btn7_Click(object sender, EventArgs e) // Numero 7
        {
            if ((CajaTexto.Text == "+") || (CajaTexto.Text == "-") || (CajaTexto.Text == "*") || (CajaTexto.Text == "/"))
            {
                CajaTexto.Text = "";
                CajaTexto.Text = CajaTexto.Text + btn7.Text;
            }
            else
            {
                CajaTexto.Text = CajaTexto.Text + btn7.Text;
            }
        }
        protected void btn8_Click(object sender, EventArgs e) // Numero 8
        {
            if ((CajaTexto.Text == "+") || (CajaTexto.Text == "-") || (CajaTexto.Text == "*") || (CajaTexto.Text == "/"))
            {
                CajaTexto.Text = "";
                CajaTexto.Text = CajaTexto.Text + btn8.Text;
            }
            else
            {
                CajaTexto.Text = CajaTexto.Text + btn8.Text;
            }
        }
        protected void btn9_Click(object sender, EventArgs e) // Numero 9
        {
            if ((CajaTexto.Text == "+") || (CajaTexto.Text == "-") || (CajaTexto.Text == "*") || (CajaTexto.Text == "/"))
            {
                CajaTexto.Text = "";
                CajaTexto.Text = CajaTexto.Text + btn9.Text;
            }
            else
            {
                CajaTexto.Text = CajaTexto.Text + btn9.Text;
            }
        }       
        protected void Button24_Click(object sender, EventArgs e) // numero 0
        {
            if ((CajaTexto.Text == "+") || (CajaTexto.Text == "-") || (CajaTexto.Text == "*") || (CajaTexto.Text == "/"))
            {
                CajaTexto.Text = "";
                CajaTexto.Text = CajaTexto.Text + btn0.Text;
            }
            else
            {
                CajaTexto.Text = CajaTexto.Text + btn0.Text;
            }
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
            } else if(Global.O == '/')
            {
                Global.Resultado = Global.Valor1 / Global.Valor2;
                CajaTexto.Text += Global.Resultado;
                Global.Valor1 = Global.Resultado;
            }
             else if (Global.O == '-')
            {
                Global.Resultado = Global.Valor1 - Global.Valor2;
                CajaTexto.Text += Global.Resultado;
                Global.Valor1 = Global.Resultado;
            } else
            {
                Global.Resultado = Global.Valor1 * Global.Valor2;
                CajaTexto.Text += Global.Resultado;
                Global.Valor1 = Global.Resultado;
            }
        }



        // Eventos de Eliminacion de Datos y el punto
        protected void btnLimpiarPantalla_Click(object sender, EventArgs e) // Limpiar Pantalla
        {
            CajaTexto.Text = "";
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
                CajaTexto.Text = "";
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
            double num = Convert.ToDouble(CajaTexto.Text);
            double resu = Math.Pow(num, 2);
            CajaTexto.Text = resu.ToString();

        }

        protected void btnLog_Click(object sender, EventArgs e) // Log
        {
            double num = Convert.ToDouble(CajaTexto.Text);
            double resu = Math.Log10(num);
            CajaTexto.Text = resu.ToString();
        }

        protected void btnBase10_Click(object sender, EventArgs e) // 10^y
        {
            double num = Convert.ToDouble(CajaTexto.Text);
            double resu = Math.Pow(10, num);
            CajaTexto.Text = resu.ToString();
        } 

        protected void btnPotencia2_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(CajaTexto.Text);
            double resu = Math.Pow(2, num);
            CajaTexto.Text = resu.ToString();
        } // x^y

        protected void btnRaiz_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(CajaTexto.Text);
            double resu = Math.Sqrt(num);
            CajaTexto.Text = resu.ToString();
        } // Raiz ²√

        protected void btnFactorial_Click(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(CajaTexto.Text);

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