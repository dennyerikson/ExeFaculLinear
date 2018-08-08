using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoLinear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Enabled(false);
        }

        private double x = 0, y = 0;

        private void btnIgual_Click(object sender, EventArgs e)
        {
           if(tbEquaX.Text != "" && tbEquaY.Text != ""  )
            {
                switch (btnIgual.Text)
                {
                    case "↑↓":
                        lbx.Text = "x + y =";
                        lby.Text = "x - y =";

                        tbEquaX.Text = "";
                        tbEquaY.Text = "";

                        Enabled(false);
                        btnIgual.Text = "=";

                        sleep = 0;
                        break;

                    case "=":
                        EquaLinearX(Convert.ToDouble(tbEquaX.Text), Convert.ToDouble(tbEquaY.Text));
                        EquaLinearY(Convert.ToDouble(tbEquaX.Text), y);

                        tSeq.Start();
                        break;
                }
                
            }
            else
            {
                MessageBox.Show("Preencha corretamente os campos, \n não são permitidos numeros negativos");
            }
        }

        public double EquaLinearX(double valor1, double valor2)
        {
            double resp;
            
                // isolando x na primeira equação
                x = valor1 - y;
                // substituo o valor de x na seguna equação
                //(x - y) - y = valor2;
                resp = (x - y) - y;
            //2y = valor2 - valor1;
            if ((valor2 - valor1) < 0)
                resp = (valor2 - valor1) * (-1);
            else
                resp = (valor2 - valor1) ;
            y = resp / 2;
            

            return y;           
        }

        public double EquaLinearY(double valor1, double valor2)
        {

            return x = valor1 - valor2;
        }

        int sleep;
        private void tSeq_Tick(object sender, EventArgs e)
        {
            sleep++;
                //x = 60 - y
            if(sleep == 1)
            {
                lbl01.Visible = true;
                lb1.Visible = true;
                lb1.Text = "x = " + tbEquaX.Text + " - y";
            }

            //(60 - y) - y = 10
            if (sleep == 2)
            {
                lbl02.Visible = true;
                lb2.Visible = true;
                lb2.Text = "("+tbEquaX.Text +" - y) - y = 10";
            }

            //2y = 10 - 60
            if (sleep == 3)
            {
                lbl03.Visible = true;
                lb4.Visible = true;
                lb4.Text = "2y = "+ tbEquaX.Text + " - "+ tbEquaY.Text;
            }

            //2y = 50
            if (sleep == 4)
            {
                lbl04.Visible = true;
                lb5.Visible = true;
                lb5.Text = "2y = "+ (Convert.ToInt16(tbEquaX.Text) - Convert.ToInt16(tbEquaY.Text));
            }

            //y = 50 / 2
            if (sleep == 5)
            {
                lbl05.Visible = true;
                lb6.Visible = true;
                lb6.Text = "y = " + (Convert.ToInt16(tbEquaX.Text) - Convert.ToInt16(tbEquaY.Text))+" / " + 2;
            }
            
            //y = 25
            if (sleep == 6)
            {
                lbl06.Visible = true;
                lb7.Visible = true;
                lb7.Text = "y="+ (Convert.ToInt16(tbEquaX.Text) - Convert.ToInt16(tbEquaY.Text)) / 2;

                lbx.Text = "x  + " + y + " = ";
                lby.Text = "x  - " + y + " = ";
            }

            //x + 25 = 60
            if (sleep == 7)
            {
                lbl07.Visible = true;
                lb8.Visible = true;
                lb8.Text = "x + "+y+" = " + (Convert.ToInt16(tbEquaX.Text));
            }
            //x = 60 - 25
            if (sleep == 8)
            {
                lbl08.Visible = true;
                lb9.Visible = true;
                lb9.Text = "x = "+ (Convert.ToInt16(tbEquaX.Text)) + " - "+y;
            }

            //x = 35
            if (sleep == 9)
            {
                lbl09.Visible = true;
                lb10.Visible = true;
                lb10.Text = "x = " + ((Convert.ToInt16(tbEquaX.Text)) - y);
            }

            if (sleep == 10)
            {
                lbx.Text = x +" + " + y + " = " + tbEquaX.Text;
                lby.Text = x +" - " + y + " = " + tbEquaY.Text;

                tSeq.Stop();
                btnIgual.Text = "↑↓";
            }
        }

       

        private void label20_Click(object sender, EventArgs e)
        {

        }

        public void Enabled(bool enabled)
        {
            lb1.Visible = enabled;
            lb2.Visible = enabled;
            lb4.Visible = enabled;
            lb5.Visible = enabled;
            lb6.Visible = enabled;
            lb7.Visible = enabled;
            lb8.Visible = enabled;
            lb9.Visible = enabled;
            lb10.Visible = enabled;

            lbl01.Visible = enabled;
            lbl02.Visible = enabled;
            lbl03.Visible = enabled;
            lbl04.Visible = enabled;
            lbl05.Visible = enabled;
            lbl06.Visible = enabled;
            lbl07.Visible = enabled;
            lbl08.Visible = enabled;
            lbl09.Visible = enabled;
        }

    }
}
