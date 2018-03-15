using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Series_y_Ciclos
{
    public partial class Form1 : Form
    {
        int[] VectorFactorial;

        public Form1()
        {
            InitializeComponent();
        }

        public double ResCos(int ValorX, int Repeticiones)
        {
            int Factorial = 1;
            double Coseno = 0.0;
            short B = 0;
            int Contador = 0;
            int Diferencia = 1;
            int Repeticion = Repeticiones;

            for (int i = 1; i <= Repeticiones + 1; i++)
            {
                Contador++;
                if (Contador > 3)
                {
                    Repeticion = Repeticion + Diferencia;
                    //txtResultado.Text = cont+"--"+i+"--"+Rept.ToString();
                }
            }
            VectorFactorial = new int[Repeticion + 1];

            for (int i = 1; i <= Repeticion; i++)
            {
                Factorial = i * Factorial;//Funciona perfectamente
                VectorFactorial[i] = Factorial;
                //txtResultado.Text += i + " -- " + Rept + " -- " + VectorFactorial[i].ToString() + Environment.NewLine;
            }

            for (int i = 1; i <= Repeticion; i++)
            {
                if (i == 1 || i == 2)
                {
                    if (i == 1)
                    {
                        Coseno = 1.0;
                    }
                    else if (i == 2)
                    {
                        Coseno = Coseno - (Math.Pow(ValorX, i) / i);
                    }
                    //txtResultado.Text += i + "--" + VectorFactorial[i] + "--" + Cos.ToString() + Environment.NewLine;
                }
                else if (i % 2 == 0)
                {
                    if (B == 0)
                    {
                        Coseno = Coseno + (Math.Pow(ValorX, i) / (VectorFactorial[i]));
                        B = 1;
                        //txtResultado.Text += i + "--" + VectorFactorial[i] + "--" + Cos.ToString() + Environment.NewLine;
                    }
                    else if (B == 1)
                    {
                        Coseno = Coseno - (Math.Pow(ValorX, i) / (VectorFactorial[i]));
                        B = 0;
                        //txtResultado.Text += i + "--" + VectorFactorial[i] + "--" + Cos.ToString() + Environment.NewLine;
                    }
                }
            }
            return Coseno;
        }

        public double ResSeno(int ValorX, int Repeticiones)
        {
            int Factorial = 1;
            double Seno = 0.0;
            short B = 0;
            int Contador = 0;
            int Diferencia = 1;
            int Repeticion = Repeticiones;

            for (int i = 1; i <= Repeticiones + 1; i++)
            {
                Contador++;
                if (Contador > 2)
                {
                    Repeticion = Repeticion + Diferencia;
                }
                //txtResultado.Text = Rept.ToString();Funciona de 3,5,7,9 ect
            }
            VectorFactorial = new int[Repeticion + 1];

            for (int i = 1; i <= Repeticion; i++)
            {
                Factorial = i * Factorial;//Funciona perfectamente
                VectorFactorial[i] = Factorial;
                //txtResultado.Text += i + " -- " + Rept + " -- " + VectorFactorial[i].ToString() + Environment.NewLine;
            }

            Seno = ValorX;
            for (int i = 1; i <= Repeticion; i++)
            {
                if (i%3==0)
                {
                    if (B == 0)
                    {
                        Seno = Seno - (Math.Pow(ValorX, i) / (VectorFactorial[i]));
                        B = 1;
                        //txtResultado.Text += i + "--" + VectorFactorial[i] + "--" + Cos.ToString() + Environment.NewLine;
                    }
                    else if (B == 1)
                    {
                        Seno = Seno + (Math.Pow(ValorX, i) / (VectorFactorial[i]));
                        B = 0;
                        //txtResultado.Text += i + "--" + VectorFactorial[i] + "--" + Cos.ToString() + Environment.NewLine;
                    }
                }
            }
            return Seno;
        }

        public double ResIn(int ValorX, int Repeticiones)
        {
            double In = 0.0;
            double Elv = 1.0;
            double Elv1 = 0.0; 

            for (int i = 1; i < Repeticiones + 1; i++)
            {
                Elv = (ValorX - 1.0)/(ValorX);
                Elv1 = Math.Pow(Elv, i);
                In = In + (1.0/i)*(Elv1);
            }
            return In;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            int Repeticiones1 = 0;
            int ValorX1 = 0;

            if (txtX.Text != "" && txtReparticiones.Text != "")
            {
                Repeticiones1 = Convert.ToInt32(txtReparticiones.Text);
                ValorX1 = Convert.ToInt32(txtX.Text);
            }

            if (txtList.Text == "COS")
            {
                txtResultado.Text = ResCos(ValorX1, Repeticiones1).ToString();
            }
            else if (txtList.Text == "SENO")
            {
                txtResultado.Text = ResSeno(ValorX1, Repeticiones1).ToString();
            }
            else if (txtList.Text == "IN")
            {
                txtResultado.Text = ResIn(ValorX1, Repeticiones1).ToString();
            }
        }
    }
}
